using Mazeed.BLL.Services.Abstraction;
using Mazeed.BLL.Services.Implementation;
using Mazeed.BLL.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Mazeed.PL.Controllers;

public class HomeController : Controller
{
    private readonly IEmailService _emailService;
    private readonly IItemService _itemService; // أو IUnitOfWork أو IShopCatalogService بحسب تسمية المشروع لديك
    private readonly ICategoryService _categoryService;
    

   

    public HomeController(IEmailService emailService, IItemService itemService, ICategoryService categoryService)
    {
        _emailService = emailService;
        _itemService = itemService;
        _categoryService = categoryService;
    }

    public IActionResult Index(long? categoryId)
    {
        // جلب البيانات من غير async
        var itemsResponse = _itemService.GetAllAsync().Result;
        var categoriesResponse = _categoryService.GetAllAsync().Result;

        var itemsList = itemsResponse?.Data ?? new List<ItemVM>();
        var categoriesList = categoriesResponse?.Data ?? new List<CategoryVM>();

        // تطبيق الفلترة
        if (categoryId.HasValue && categoryId > 0)
        {
            itemsList = itemsList.Where(item => item.CategoryIds != null && item.CategoryIds.Contains(categoryId.Value));
        }

        var model = new ShopCatalogVM
        {
            CategoryId = categoryId,
            Items = itemsList,
            Categories = categoriesList
        };

        return View(model);
    }

    public IActionResult Privacy() => View();

    #region 
    [HttpGet]
    public IActionResult Contact() => View();

    [HttpGet]
    public IActionResult About() =>  View(); 
    public IActionResult Help() => View();
    [HttpGet]
    public IActionResult Electronics()
    {
        // 1. جلب البيانات من السيرفس
        var response = _itemService.GetAllAsync().GetAwaiter().GetResult();
        var allItems = response?.Data ?? Enumerable.Empty<ItemVM>();

        // 2. فلترة المنتجات الخاصة بقسم الإلكترونيات (CategoryId = 1)
        var electronicsItems = allItems.Where(item =>
            item.CategoryIds != null && item.CategoryIds.Contains(1)
        ).ToList();

        // 3. تجهيز الـ ViewModel
        var model = new ShopCatalogVM
        {
            Items = electronicsItems,
            CategoryId = 1,
            MinPrice = null,
            MaxPrice = null
        };

        return View(model);
    }

    [HttpPost, ValidateAntiForgeryToken]
    public async Task<IActionResult> Contact(ContactVM model)
    {
        if (!ModelState.IsValid) return View(model);

        try
        {
            await _emailService.ProcessContactFormAsync(model);
            TempData["Success"] = "Your message has been sent successfully. We will get back to you soon.";
            return RedirectToAction(nameof(Index));
        }
        catch (Exception ex)
        {
            ModelState.AddModelError(string.Empty, "An error occurred while sending your message. Please try again later.");
            return View(model);
        }
    }
    #endregion
}
