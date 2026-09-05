using System.Security.Claims;
using Mazeed.BLL.Services.Abstraction;
using Mazeed.BLL.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Mazeed.Web.Controllers
{
    public class StoreController : Controller
    {
        private readonly IItemService _itemService;
        private readonly ICategoryService _categoryService;
        private readonly IBrandService _brandService;
        private readonly IRecommendationService _recommendationService;

        public StoreController(
            IItemService itemService,
            ICategoryService categoryService,
            IBrandService brandService,
            IRecommendationService recommendationService)
        {
            _itemService = itemService;
            _categoryService = categoryService;
            _brandService = brandService;
            _recommendationService = recommendationService;
        }

        public async Task<IActionResult> Index(
            string? searchQuery,
            string? sortBy,
            long? brandId,
            long? categoryId,
            decimal? minPrice,
            decimal? maxPrice)
        {
            var itemsResponse = await _itemService.GetAllAsync();
            var categoriesResponse = await _categoryService.GetAllAsync();
            var brandsResponse = await _brandService.GetAllAsync();

            var itemsList = itemsResponse?.Data?.ToList() ?? new List<ItemVM>();
            var categoriesList = categoriesResponse?.Data?.ToList() ?? new List<CategoryVM>();
            var brandsList = brandsResponse?.Data?.ToList() ?? new List<BrandVM>();

            // 1. استخراج الـ UserId الخاص بالعميل المسجل حالياً
            long? userId = null;
            if (User?.Identity != null && User.Identity.IsAuthenticated)
            {
                var userIdStr = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
                if (long.TryParse(userIdStr, out long parsedId)) userId = parsedId;
            }

            // حساب الحدود الدنيا والعليا للأسعار المتاحة
            decimal dbMinPrice = itemsList.Any() ? itemsList.Min(i => i.Price) : 0m;
            decimal dbMaxPrice = itemsList.Any() ? itemsList.Max(i => i.Price) : 0m;

            // بناء الخرائط للفلترة اللحظية (Category to Brand mapping & Items Meta)
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

            var itemsFilterMeta = itemsList.Select(i => new ItemFilterMetaVM
            {
                Id = i.Id,
                Name = i.Name,
                BrandId = i.BrandId,
                Price = i.Price,
                CategoryIds = i.CategoryIds ?? new List<long>()
            }).ToList();

            var filteredItems = itemsList.AsEnumerable();

            // 2. تطبيق الترتيب التوصيات (Recommendation) لو العميل مش محدد ترتيب معين (sortBy)
            if (string.IsNullOrEmpty(sortBy))
            {
                filteredItems = _recommendationService.GetHomeRecommendations(userId, itemsList);
            }

            // 3. Search Query Filter
            if (!string.IsNullOrWhiteSpace(searchQuery))
            {
                filteredItems = filteredItems.Where(i =>
                    (i.Name != null && i.Name.Contains(searchQuery, StringComparison.OrdinalIgnoreCase)) ||
                    (i.BrandName != null && i.BrandName.Contains(searchQuery, StringComparison.OrdinalIgnoreCase)) ||
                    (i.CategoryNames != null && i.CategoryNames.Any(c => c.Contains(searchQuery, StringComparison.OrdinalIgnoreCase)))
                );
            }

            // 4. Brand Filter
            if (brandId.HasValue && brandId > 0)
            {
                filteredItems = filteredItems.Where(i => i.BrandId == brandId.Value);
            }

            // 5. Category Filter
            if (categoryId.HasValue && categoryId > 0)
            {
                filteredItems = filteredItems.Where(i => i.CategoryIds != null && i.CategoryIds.Contains(categoryId.Value));
            }

            // 6. Price Filters
            if (minPrice.HasValue)
            {
                filteredItems = filteredItems.Where(i => i.Price >= minPrice.Value);
            }
            if (maxPrice.HasValue)
            {
                filteredItems = filteredItems.Where(i => i.Price <= maxPrice.Value);
            }

            // 7. Explicit Sorting (إعادة الترتيب بالـ SortBy الصريح إذا اختار العميل خيار محدد)
            if (!string.IsNullOrEmpty(sortBy))
            {
                filteredItems = sortBy switch
                {
                    "price_low_high" => filteredItems.OrderBy(i => i.Price),
                    "price_high_low" => filteredItems.OrderByDescending(i => i.Price),
                    "name_asc" => filteredItems.OrderBy(i => i.Name),
                    "name_desc" => filteredItems.OrderByDescending(i => i.Name),
                    _ => filteredItems
                };
            }

            var viewModel = new ShopCatalogVM
            {
                SearchQuery = searchQuery,
                SortBy = sortBy,
                BrandId = brandId,
                CategoryId = categoryId,
                MinPrice = minPrice,
                MaxPrice = maxPrice,
                DbMinPrice = dbMinPrice,
                DbMaxPrice = dbMaxPrice,
                CategoryBrandMap = categoryBrandMap,
                ItemsFilterMeta = itemsFilterMeta,
                Items = filteredItems.ToList(),
                Brands = brandsList,
                Categories = categoriesList
            };

            return View(viewModel);
        }

        [HttpGet]
        public async Task<IActionResult> GetSuggestions(string query)
        {
            if (string.IsNullOrWhiteSpace(query))
            {
                return Json(new List<string>());
            }

            var itemsResponse = await _itemService.GetAllAsync();
            var items = itemsResponse?.Data ?? new List<ItemVM>();

            var itemNames = items
                .Where(i => i.Name != null && i.Name.StartsWith(query, StringComparison.OrdinalIgnoreCase))
                .Select(i => i.Name);

            var brandNames = items
                .Where(i => i.BrandName != null && i.BrandName.StartsWith(query, StringComparison.OrdinalIgnoreCase))
                .Select(i => i.BrandName!);

            var categoryNames = items
                .SelectMany(i => i.CategoryNames ?? new List<string>())
                .Where(c => c.StartsWith(query, StringComparison.OrdinalIgnoreCase));

            var suggestions = itemNames
                .Concat(brandNames)
                .Concat(categoryNames)
                .Distinct(StringComparer.OrdinalIgnoreCase)
                .Take(8)
                .ToList();

            return Json(suggestions);
        }
    }
}