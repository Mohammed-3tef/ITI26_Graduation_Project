using Mazeed.BLL.Services.Abstraction;
using Mazeed.BLL.Services.Implementation;
using Mazeed.BLL.ViewModels;
using Mazeed.BLL.ViewModels.Search;
using Microsoft.AspNetCore.Mvc;

namespace Mazeed.PL.Controllers;

public class HomeController : Controller
{
    private readonly IEmailService _emailService;
    private readonly IItemService _itemService;
    private readonly IItemVariantService _itemVariantService;
    private readonly ICategoryService _categoryService;
    private readonly IBrandService _brandService;

    public HomeController(IEmailService emailService, IItemService itemService,
            ICategoryService categoryService,
            IBrandService brandService,
            IItemVariantService itemVariantService)
    {
        _emailService = emailService;
        _itemService = itemService;
        _categoryService = categoryService;
        _brandService = brandService;
        _itemVariantService = itemVariantService;
    }

    // الصفحة الرئيسية
    [HttpGet]
    public async Task<IActionResult> Index(FilterSortViewModel model)
    {
        // 1. Fetch metadata options to populate layout dropdown fields
        var itemsResponse = await _itemService.GetAllAsync();
        var categoriesResponse = await _categoryService.GetAllAsync();
        var brandsResponse = await _brandService.GetAllAsync();
        var colorsResponse = await _itemVariantService.GetDistinctColors();
        var sizeResponse = await _itemVariantService.GetDistinctSize();

        var productsList = itemsResponse.Data ?? new List<ItemVM>();

        model.AvailableCategories = categoriesResponse?.Data?.ToList() ?? new List<CategoryVM>();
        model.AvailableBrands = brandsResponse?.Data?.ToList() ?? new List<BrandVM>();
        model.AvailableColors = colorsResponse?.Data?.ToList() ?? new List<ColorItem>();
        model.AvailableSizes = sizeResponse?.Data?.ToList() ?? new List<string>();

        // Fallback range handles initialization
        model.MinPrice ??= 0;
        model.MaxPrice ??= 100000000;

        var filteredQuery = productsList.AsQueryable();

        // 2. Apply Text Navbar Search Filter (Item Name, Brand, Categories)
        if (!string.IsNullOrWhiteSpace(model.SearchQuery))
        {
            filteredQuery = filteredQuery.Where(i =>
                (i.Name != null && i.Name.Contains(model.SearchQuery, StringComparison.OrdinalIgnoreCase)) ||
                (i.BrandName != null && i.BrandName.Contains(model.SearchQuery, StringComparison.OrdinalIgnoreCase)) ||
                (i.CategoryNames != null && i.CategoryNames.Any(c => c.Contains(model.SearchQuery, StringComparison.OrdinalIgnoreCase)))
            );
        }

        // 3. Multi-Select Category Filters
        if (model.SelectedCategoryIds != null && model.SelectedCategoryIds.Any())
        {
            filteredQuery = filteredQuery.Where(p => p.CategoryIds != null && p.CategoryIds.Any(id => model.SelectedCategoryIds.Contains(id)));
        }

        // 4. Multi-Select Brand Filters
        if (model.SelectedBrandIds != null && model.SelectedBrandIds.Any())
        {
            // Force the evaluation in memory cleanly
            filteredQuery = filteredQuery.Where(p => model.SelectedBrandIds.Contains(p.BrandId));
        }


        // 5. Variant Size Filters
        if (model.SelectedSizes != null && model.SelectedSizes.Any())
        {
            filteredQuery = filteredQuery.Where(p => p.Variants != null && p.Variants.Any(v => model.SelectedSizes.Contains(v.Size)));
        }

        // 6. Variant Color Filters
        if (model.SelectedColors != null && model.SelectedColors.Any())
        {
            filteredQuery = filteredQuery.Where(p => p.Variants != null && p.Variants.Any(v => model.SelectedColors.Contains(v.Color)));
        }

        // 7. Double Pricing Filter Track constraints
        filteredQuery = filteredQuery.Where(p => p.Price >= model.MinPrice.Value && p.Price <= model.MaxPrice.Value);

        // 8. Sorting Rule evaluation
        filteredQuery = model.SelectedSort switch
        {
            "lowToHigh" => filteredQuery.OrderBy(p => p.Price),
            "highToLow" => filteredQuery.OrderByDescending(p => p.Price),
            _ => filteredQuery.OrderByDescending(p => p.Id) // Recommended Order
        };

        // 9. Assign calculation results back to view payload data context
        model.Items = filteredQuery.ToList();
        model.TotalCount = model.Items.Count; // Calculates numerical indicator for action apply button

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

    [HttpGet]
    public IActionResult Details(long id)
    {
        var allItems = _itemService.GetAllAsync().Result?.Data ?? new List<ItemVM>();
        var item = allItems.FirstOrDefault(i => i.Id == id);

        if (item == null) return NotFound();

        var variants = item.Variants ?? new List<ItemVariantVM>();

        // استخراج الألوان والمقاسات الفريدة من الـ Variants
        var colors = variants
            .Select(v => v.Color)
            .Where(c => !string.IsNullOrEmpty(c))
            .Distinct()
            .ToList();

        var sizes = variants
            .Select(v => v.Size)
            .Where(s => !string.IsNullOrEmpty(s))
            .Distinct()
            .ToList();

        // Recommendation System (منتجات من نفس القسم)
        var relatedItems = allItems
            .Where(i => i.Id != id && i.CategoryIds != null && item.CategoryIds != null && i.CategoryIds.Intersect(item.CategoryIds).Any())
            .Take(3)
            .ToList();

        var model = new ItemDetailsVM
        {
            Product = item,
            Variants = variants,
            AvailableColors = colors,
            AvailableSizes = sizes,
            RelatedProducts = relatedItems
        };

        return View(model);
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