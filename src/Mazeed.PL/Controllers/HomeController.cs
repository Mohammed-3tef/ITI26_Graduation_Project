using Mazeed.BLL.Services.Abstraction;
using Mazeed.BLL.Services.Implementation;
using Mazeed.BLL.ViewModels;
using Mazeed.BLL.ViewModels.Search;
﻿using System.Security.Claims;
using Mazeed.BLL.Services.Abstraction;
using Mazeed.BLL.Services.Implementation;
using Mazeed.BLL.ViewModels;
using Mazeed.DAL.Entities;
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
    private readonly IRecommendationService _recommendationService;
    private readonly IBrandService _brandService;

    public HomeController(IEmailService emailService, IItemService itemService, ICategoryService categoryService, IRecommendationService recommendationService, IBrandService brandService)
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
        _recommendationService = recommendationService;
        _brandService = brandService;
    }

    // الصفحة الرئيسية


    // 1. Index Action
    // 1. Index Action
    public async Task<IActionResult> Index(long? categoryId, string? sortBy, decimal? minPrice, decimal? maxPrice, string? searchQuery)
    {
        var itemsResponse = await _itemService.GetAllAsync();
        var categoriesResponse = await _categoryService.GetAllAsync();

        var brandsResponse = _brandService != null ? await _brandService.GetAllAsync() : null;
        var brandsList = brandsResponse?.Data?.ToList() ?? new List<BrandVM>();
        var itemsList = itemsResponse?.Data?.ToList() ?? new List<ItemVM>();
        var categoriesList = categoriesResponse?.Data?.ToList() ?? new List<CategoryVM>();

        long? userId = null;
        if (User?.Identity != null && User.Identity.IsAuthenticated)
        {
            var userIdStr = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
            if (long.TryParse(userIdStr, out long parsedId)) userId = parsedId;
        }

        // 1. الفلترة حسب الكاتيجوري أو تطبيق التوصيات
        // 1. الفلترة حسب الكاتيجوري مع تطبيق الـ Recommendation
        if (categoryId.HasValue && categoryId > 0)
        {
            var categoryItems = itemsList
                .Where(item => item.CategoryIds != null && item.CategoryIds.Contains(categoryId.Value))
                .ToList();

            // نمرر المنتجات للسيرفس لتترتب بالتوصيات لو المستخدم ماختارش ترتيب يدوي
            if (string.IsNullOrEmpty(sortBy))
            {
                itemsList = _recommendationService.GetHomeRecommendations(userId, categoryItems);
            }
            else
            {
                itemsList = categoryItems;
            }
        }
        else if (string.IsNullOrEmpty(searchQuery) && !minPrice.HasValue && !maxPrice.HasValue && string.IsNullOrEmpty(sortBy))
        {
            // زر All أو الفتح لأول مرة: ترتيب الكاتالوج كامل
            itemsList = _recommendationService.GetHomeRecommendations(userId, itemsList);
        }

        // 2. الفلترة المتقدمة (Price & Search)
        if (!string.IsNullOrEmpty(searchQuery))
        {
            itemsList = itemsList.Where(i => i.Name.Contains(searchQuery, StringComparison.OrdinalIgnoreCase)).ToList();
>>>>>>> 08c6a04de4e21dd5183be56b387361672ca385eb
        }
        if (minPrice.HasValue)
        {
            itemsList = itemsList.Where(i => i.Price >= minPrice.Value).ToList();
        }
        if (maxPrice.HasValue)
        {
            itemsList = itemsList.Where(i => i.Price <= maxPrice.Value).ToList();
        }

        // 3. الترتيب
        if (!string.IsNullOrEmpty(sortBy))
        {
            itemsList = sortBy switch
            {
                "price_low_high" => itemsList.OrderBy(i => i.Price).ToList(),
                "price_high_low" => itemsList.OrderByDescending(i => i.Price).ToList(),
                "name_asc" => itemsList.OrderBy(i => i.Name).ToList(),
                "name_desc" => itemsList.OrderByDescending(i => i.Name).ToList(),
                _ => itemsList
            };
        }

        var model = new ShopCatalogVM
        {
            CategoryId = categoryId,
            Items = itemsList,
            Categories = categoriesList,
            Brands = brandsList,
            SortBy = sortBy,
            MinPrice = minPrice,
            MaxPrice = maxPrice,
            SearchQuery = searchQuery,
        };

        return View(model);
    }
    // 2. Details Action
    public async Task<IActionResult> Details(long id)
    {
        var itemsResponse = await _itemService.GetAllAsync();
        var allItems = itemsResponse?.Data?.ToList() ?? new List<ItemVM>();
        var item = allItems.FirstOrDefault(i => i.Id == id);

        if (item == null) return NotFound();

        var variants = item.Variants?.ToList() ?? new List<ItemVariantVM>();

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

        var relatedItems = _recommendationService.GetRelatedOrBoughtTogether(id, allItems, count: 3);

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

    // 3. Category Action
    public async Task<IActionResult> Category(long? id, string? sortBy, decimal? minPrice, decimal? maxPrice)
    {
        var itemsResponse = await _itemService.GetAllAsync();
        var categoriesResponse = await _categoryService.GetAllAsync();

        var itemsList = itemsResponse?.Data?.ToList() ?? new List<ItemVM>();
        var categoriesList = categoriesResponse?.Data?.ToList() ?? new List<CategoryVM>();

        long? userId = null;
        if (User?.Identity != null && User.Identity.IsAuthenticated)
        {
            var userIdStr = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
            if (long.TryParse(userIdStr, out long parsedId)) userId = parsedId;
        }

        // 1. التعديل هنا: فلترة حسب الكاتيجوري ثم ترتيب النتائج بالتوصيات الخاصة بالمستخدم
        if (id.HasValue && id > 0)
        {
            var categoryItems = itemsList.Where(item => item.CategoryIds != null && item.CategoryIds.Contains(id.Value)).ToList();

            // لو لم يحدد المستخدم ترتيب معين للـ Sort، نقوم بترتيب منتجات الكاتيجوري بالتوصيات
            if (string.IsNullOrEmpty(sortBy))
            {
                itemsList = _recommendationService.GetHomeRecommendations(userId, categoryItems);
            }
            else
            {
                itemsList = categoryItems;
            }
        }
        else
        {
            // بدون count: 12 لإرجاع القائمة كاملة
            if (string.IsNullOrEmpty(sortBy))
            {
                itemsList = _recommendationService.GetHomeRecommendations(userId, itemsList);
            }
        }

        // 2. الفلترة بالسعر
        if (minPrice.HasValue)
        {
            itemsList = itemsList.Where(i => i.Price >= minPrice.Value).ToList();
        }
        if (maxPrice.HasValue)
        {
            itemsList = itemsList.Where(i => i.Price <= maxPrice.Value).ToList();
        }

        // 3. الترتيب (إذا اختار المستخدم ترتيب يدوي)
        if (!string.IsNullOrEmpty(sortBy))
        {
            itemsList = sortBy switch
            {
                "price_low_high" => itemsList.OrderBy(i => i.Price).ToList(),
                "price_high_low" => itemsList.OrderByDescending(i => i.Price).ToList(),
                "name_asc" => itemsList.OrderBy(i => i.Name).ToList(),
                "name_desc" => itemsList.OrderByDescending(i => i.Name).ToList(),
                _ => itemsList
            };
        }

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