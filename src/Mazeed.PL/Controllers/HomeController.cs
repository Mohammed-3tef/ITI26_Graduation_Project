using System.Security.Claims;
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
    private readonly ICategoryService _categoryService;
    private readonly IRecommendationService _recommendationService;
    private readonly IBrandService _brandService;

    public HomeController(IEmailService emailService, IItemService itemService, ICategoryService categoryService, IRecommendationService recommendationService, IBrandService brandService)
    {
        _emailService = emailService;
        _itemService = itemService;
        _categoryService = categoryService;
        _recommendationService = recommendationService;
        _brandService = brandService;
    }

    // 1. Index Action
    public async Task<IActionResult> Index(long? categoryId, long? brandId, string? sortBy, decimal? minPrice, decimal? maxPrice, string? searchQuery)
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

        // حساب القيم الدنيا والعليا للأسعار من الداتابيز
        decimal dbMinPrice = itemsList.Any() ? itemsList.Min(i => i.Price) : 0m;
        decimal dbMaxPrice = itemsList.Any() ? itemsList.Max(i => i.Price) : 0m;

        // بناء الـ CategoryBrandMap لتشغيل فلترة البراندات ديناميكياً
        var categoryBrandMap = new Dictionary<long, List<long>>();
        foreach (var item in itemsList)
        {
            if (item.CategoryIds != null)
            {
                foreach (var catId in item.CategoryIds)
                {
                    if (!categoryBrandMap.ContainsKey(catId))
                        categoryBrandMap[catId] = new List<long>();

                    if (item.BrandId > 0 && !categoryBrandMap[catId].Contains(item.BrandId))
                        categoryBrandMap[catId].Add(item.BrandId);
                }
            }
        }

        // بناء الـ ItemsFilterMeta للفلترة اللحظية في الفلونت أوفكانفاس
        var itemsFilterMeta = itemsList.Select(i => new ItemFilterMetaVM
        {
            Id = i.Id,
            Name = i.Name,
            BrandId = i.BrandId,
            Price = i.Price,
            CategoryIds = i.CategoryIds ?? new List<long>()
        }).ToList();

        // 1. الفلترة حسب الكاتيجوري مع تطبيق الـ Recommendation
        if (categoryId.HasValue && categoryId > 0)
        {
            var categoryItems = itemsList
                .Where(item => item.CategoryIds != null && item.CategoryIds.Contains(categoryId.Value))
                .ToList();

            if (string.IsNullOrEmpty(sortBy))
            {
                itemsList = _recommendationService.GetHomeRecommendations(userId, categoryItems);
            }
            else
            {
                itemsList = categoryItems;
            }
        }
        else if (string.IsNullOrEmpty(searchQuery) && !brandId.HasValue && !minPrice.HasValue && !maxPrice.HasValue && string.IsNullOrEmpty(sortBy))
        {
            itemsList = _recommendationService.GetHomeRecommendations(userId, itemsList);
        }

        // 2. الفلترة المتقدمة (Brand, Price & Search)
        if (brandId.HasValue && brandId > 0)
        {
            itemsList = itemsList.Where(i => i.BrandId == brandId.Value).ToList();
        }
        if (!string.IsNullOrEmpty(searchQuery))
        {
            itemsList = itemsList.Where(i => i.Name.Contains(searchQuery, StringComparison.OrdinalIgnoreCase)).ToList();
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
            BrandId = brandId,
            Items = itemsList,
            Categories = categoriesList,
            Brands = brandsList,
            SortBy = sortBy,
            MinPrice = minPrice,
            MaxPrice = maxPrice,
            DbMinPrice = dbMinPrice,
            DbMaxPrice = dbMaxPrice,
            SearchQuery = searchQuery,
            CategoryBrandMap = categoryBrandMap,
            ItemsFilterMeta = itemsFilterMeta
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
    public async Task<IActionResult> Category(long? id, long? brandId, string? sortBy, decimal? minPrice, decimal? maxPrice)
    {
        var itemsResponse = await _itemService.GetAllAsync();
        var categoriesResponse = await _categoryService.GetAllAsync();
        var brandsResponse = _brandService != null ? await _brandService.GetAllAsync() : null;

        var itemsList = itemsResponse?.Data?.ToList() ?? new List<ItemVM>();
        var categoriesList = categoriesResponse?.Data?.ToList() ?? new List<CategoryVM>();
        var brandsList = brandsResponse?.Data?.ToList() ?? new List<BrandVM>();

        long? userId = null;
        if (User?.Identity != null && User.Identity.IsAuthenticated)
        {
            var userIdStr = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
            if (long.TryParse(userIdStr, out long parsedId)) userId = parsedId;
        }

        // 1. تحديد المنتجات المتاحة في هذه الفئة
        List<ItemVM> baseCategoryItems = itemsList;
        if (id.HasValue && id > 0)
        {
            baseCategoryItems = itemsList.Where(item => item.CategoryIds != null && item.CategoryIds.Contains(id.Value)).ToList();

            // إظهار فقط البراندات المتاحة لهذه الكاتيجوري
            var availableBrandIds = baseCategoryItems.Select(i => i.BrandId).Where(bId => bId > 0).Distinct().ToList();
            brandsList = brandsList.Where(b => availableBrandIds.Contains(b.Id)).ToList();
        }

        // حساب السعر الأقل والأعلى الخاص بالمنتجات المتاحة
        decimal dbMinPrice = baseCategoryItems.Any() ? baseCategoryItems.Min(i => i.Price) : 0m;
        decimal dbMaxPrice = baseCategoryItems.Any() ? baseCategoryItems.Max(i => i.Price) : 0m;

        // إعداد CategoryBrandMap للفلترة الديناميكية
        var categoryBrandMap = new Dictionary<long, List<long>>();
        foreach (var item in baseCategoryItems)
        {
            if (item.CategoryIds != null)
            {
                foreach (var catId in item.CategoryIds)
                {
                    if (!categoryBrandMap.ContainsKey(catId))
                        categoryBrandMap[catId] = new List<long>();

                    if (item.BrandId > 0 && !categoryBrandMap[catId].Contains(item.BrandId))
                        categoryBrandMap[catId].Add(item.BrandId);
                }
            }
        }

        // إعداد ItemsFilterMeta اللحظية الخاصة بمنتجات هذه الفئة فقط
        var itemsFilterMeta = baseCategoryItems.Select(i => new ItemFilterMetaVM
        {
            Id = i.Id,
            Name = i.Name,
            BrandId = i.BrandId,
            Price = i.Price,
            CategoryIds = i.CategoryIds ?? new List<long>()
        }).ToList();

        // ترتيب التوصيات
        if (id.HasValue && id > 0)
        {
            if (string.IsNullOrEmpty(sortBy))
            {
                itemsList = _recommendationService.GetHomeRecommendations(userId, baseCategoryItems);
            }
            else
            {
                itemsList = baseCategoryItems;
            }
        }
        else
        {
            if (string.IsNullOrEmpty(sortBy))
            {
                itemsList = _recommendationService.GetHomeRecommendations(userId, itemsList);
            }
        }

        // 2. الفلترة المتقدمة (Brand & Price)
        if (brandId.HasValue && brandId > 0)
        {
            itemsList = itemsList.Where(i => i.BrandId == brandId.Value).ToList();
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
            CategoryId = id,
            BrandId = brandId,
            Items = itemsList,
            Categories = categoriesList,
            Brands = brandsList,
            SortBy = sortBy,
            MinPrice = minPrice,
            MaxPrice = maxPrice,
            DbMinPrice = dbMinPrice,
            DbMaxPrice = dbMaxPrice,
            CategoryBrandMap = categoryBrandMap,
            ItemsFilterMeta = itemsFilterMeta
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

    [HttpGet]
    public IActionResult Terms() => View();

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