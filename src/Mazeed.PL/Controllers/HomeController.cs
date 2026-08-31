using Mazeed.BLL.Services.Abstraction;
using Mazeed.BLL.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Mazeed.PL.Controllers;

public class HomeController : Controller
{
    private readonly IEmailService _emailService;
    private readonly IItemService _itemService;
    private readonly ICategoryService _categoryService;

    public HomeController(IEmailService emailService, IItemService itemService, ICategoryService categoryService)
    {
        _emailService = emailService;
        _itemService = itemService;
        _categoryService = categoryService;
    }

    // الصفحة الرئيسية
    public IActionResult Index(long? categoryId)
    {
        var itemsResponse = _itemService.GetAllAsync().Result;
        var categoriesResponse = _categoryService.GetAllAsync().Result;

        var itemsList = itemsResponse?.Data ?? new List<ItemVM>();
        var categoriesList = categoriesResponse?.Data ?? new List<CategoryVM>();

        if (categoryId.HasValue && categoryId > 0)
        {
            itemsList = itemsList.Where(item => item.CategoryIds != null && item.CategoryIds.Contains(categoryId.Value)).ToList();
        }

        var model = new ShopCatalogVM
        {
            CategoryId = categoryId,
            Items = itemsList,
            Categories = categoriesList
        };

        return View(model);
    }

    // أكشن موحد لعرض أي كاتيجوري يتم الضغط عليه من الـ Navbar
    [HttpGet]
    public IActionResult Category(long? id, string? sortBy, decimal? minPrice, decimal? maxPrice)
    {
        var itemsResponse = _itemService.GetAllAsync().Result;
        var categoriesResponse = _categoryService.GetAllAsync().Result;

        var itemsList = itemsResponse?.Data ?? new List<ItemVM>();
        var categoriesList = categoriesResponse?.Data ?? new List<CategoryVM>();

        // 1. الفلترة حسب الكاتيجوري
        if (id.HasValue && id > 0)
        {
            itemsList = itemsList.Where(item => item.CategoryIds != null && item.CategoryIds.Contains(id.Value)).ToList();
        }

        // 2. الفلترة حسب السعر
        if (minPrice.HasValue)
        {
            itemsList = itemsList.Where(i => i.Price >= minPrice.Value).ToList();
        }
        if (maxPrice.HasValue)
        {
            itemsList = itemsList.Where(i => i.Price <= maxPrice.Value).ToList();
        }

        // 3. الترتيب (Sort By)
        itemsList = sortBy switch
        {
            "price_low_high" => itemsList.OrderBy(i => i.Price).ToList(),
            "price_high_low" => itemsList.OrderByDescending(i => i.Price).ToList(),
            "name_asc" => itemsList.OrderBy(i => i.Name).ToList(),
            "name_desc" => itemsList.OrderByDescending(i => i.Name).ToList(),
            _ => itemsList.ToList()
        };

        var model = new ShopCatalogVM
        {
            CategoryId = id,
            Items = itemsList,
            Categories = categoriesList,
            SortBy = sortBy,
            MinPrice = minPrice,
            MaxPrice = maxPrice
        };

        return View("CategoryCatalog", model);
    }

    public IActionResult Privacy() => View();

    #region Static Pages & Contact
    [HttpGet]
    public IActionResult Contact() => View();

    [HttpGet]
    public IActionResult About() => View();

    [HttpGet]
    public IActionResult Help() => View();

    [HttpPost, ValidateAntiForgeryToken]
    public IActionResult Contact(ContactVM model)
    {
        if (!ModelState.IsValid) return View(model);

        try
        {
            _emailService.ProcessContactFormAsync(model).Wait();
            TempData["Success"] = "Your message has been sent successfully. We will get back to you soon.";
            return RedirectToAction(nameof(Index));
        }
        catch (Exception)
        {
            ModelState.AddModelError(string.Empty, "An error occurred while sending your message. Please try again later.");
            return View(model);
        }
    }
    #endregion
}