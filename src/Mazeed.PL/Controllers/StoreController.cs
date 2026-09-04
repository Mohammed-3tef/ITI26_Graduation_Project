using Mazeed.BLL.Services.Abstraction;
using Mazeed.BLL.ViewModels;
using Mazeed.BLL.ViewModels.Search;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Mazeed.Web.Controllers
{
    public class StoreController : Controller
    {
        private readonly IItemService _itemService;
        private readonly IItemVariantService _itemVariantService;
        private readonly ICategoryService _categoryService;
        private readonly IBrandService _brandService;

        public StoreController(
            IItemService itemService,
            ICategoryService categoryService,
            IBrandService brandService,
            IItemVariantService itemVariantService)
        {
            _itemService = itemService;
            _categoryService = categoryService;
            _brandService = brandService;
            _itemVariantService = itemVariantService;
        }

        //public async Task<IActionResult> Index(
        //    string? searchQuery,
        //    string? sortBy,
        //    long? brandId,
        //    long? categoryId,
        //    decimal? minPrice,
        //    decimal? maxPrice)
        //{
        //    var itemsResponse = await _itemService.GetAllAsync();
        //    var categoriesResponse = await _categoryService.GetAllAsync();
        //    var brandsResponse = await _brandService.GetAllAsync();

        //    var items = itemsResponse.Data ?? new List<ItemVM>();

        //    // 1. Search Query Filter (Item Name, Brand Name, Category Name)
        //    if (!string.IsNullOrWhiteSpace(searchQuery))
        //    {
        //        items = items.Where(i =>
        //            (i.Name != null && i.Name.Contains(searchQuery, StringComparison.OrdinalIgnoreCase)) ||
        //            (i.BrandName != null && i.BrandName.Contains(searchQuery, StringComparison.OrdinalIgnoreCase)) ||
        //            (i.CategoryNames != null && i.CategoryNames.Any(c => c.Contains(searchQuery, StringComparison.OrdinalIgnoreCase)))
        //        );
        //    }

        //    // 2. Brand Filter
        //    if (brandId.HasValue)
        //    {
        //        items = items.Where(i => i.BrandId == brandId.Value);
        //    }

        //    // 3. Category Filter
        //    if (categoryId.HasValue)
        //    {
        //        items = items.Where(i => i.CategoryIds != null && i.CategoryIds.Contains(categoryId.Value));
        //    }

        //    // 4. Price Filters
        //    if (minPrice.HasValue)
        //    {
        //        items = items.Where(i => i.Price >= minPrice.Value);
        //    }
        //    if (maxPrice.HasValue)
        //    {
        //        items = items.Where(i => i.Price <= maxPrice.Value);
        //    }

        //    // 5. Sorting
        //    items = sortBy switch
        //    {
        //        "price_low_high" => items.OrderBy(i => i.Price),
        //        "price_high_low" => items.OrderByDescending(i => i.Price),
        //        "name_asc" => items.OrderBy(i => i.Name),
        //        "name_desc" => items.OrderByDescending(i => i.Name),
        //        _ => items
        //    };

        //    var viewModel = new ShopCatalogVM
        //    {
        //        SearchQuery = searchQuery,
        //        SortBy = sortBy,
        //        BrandId = brandId,
        //        CategoryId = categoryId,
        //        MinPrice = minPrice,
        //        MaxPrice = maxPrice,
        //        Items = items.ToList(),
        //        Brands = brandsResponse.Data ?? new List<BrandVM>(),
        //        Categories = categoriesResponse.Data ?? new List<CategoryVM>()
        //    };

        //    return View(viewModel);
        //}

        //// Endpoint للـ AJAX Suggestions أثناء الكتابة
        //[HttpGet]
        //public async Task<IActionResult> GetSuggestions(string query)
        //{
        //    if (string.IsNullOrWhiteSpace(query))
        //    {
        //        return Json(new List<string>());
        //    }

        //    var itemsResponse = await _itemService.GetAllAsync();
        //    var items = itemsResponse.Data ?? new List<ItemVM>();

        //    // إرجاع الأسماء التي تبدأ بالمدخلات (Starts With) للإيتام والبراند والكتيجوري
        //    var itemNames = items
        //        .Where(i => i.Name != null && i.Name.StartsWith(query, StringComparison.OrdinalIgnoreCase))
        //        .Select(i => i.Name);

        //    var brandNames = items
        //        .Where(i => i.BrandName != null && i.BrandName.StartsWith(query, StringComparison.OrdinalIgnoreCase))
        //        .Select(i => i.BrandName!);

        //    var categoryNames = items
        //        .SelectMany(i => i.CategoryNames ?? new List<string>())
        //        .Where(c => c.StartsWith(query, StringComparison.OrdinalIgnoreCase));

        //    var suggestions = itemNames
        //        .Concat(brandNames)
        //        .Concat(categoryNames)
        //        .Distinct(StringComparer.OrdinalIgnoreCase)
        //        .Take(8)
        //        .ToList();

        //    return Json(suggestions);
        //}
        [HttpGet]
        public async Task<IActionResult> Index(FilterSortViewModel model)
        {
            // 1. جلب الفئات والبراندات ديناميكياً من الجداول وتحويلها للـ VM
            var itemsResponse = await _itemService.GetAllAsync();
            var categoriesResponse = await _categoryService.GetAllAsync();
            var brandsResponse = await _brandService.GetAllAsync();
            var colorsResponse = await _itemVariantService.GetDistinctColors();
            var sizeResponse = await _itemVariantService.GetDistinctSize();

            var productsQuery = itemsResponse.Data ?? new List<ItemVM>();

            model.AvailableCategories = categoriesResponse?.Data?.ToList() ?? new List<CategoryVM>();

            model.AvailableBrands = brandsResponse?.Data?.ToList() ?? new List<BrandVM>();

            model.AvailableColors = colorsResponse?.Data?.ToList() ?? new List<ColorItem>();

            model.AvailableSizes = sizeResponse?.Data?.ToList() ?? new List<string>();

            // 2. بناء استعلام المنتجات (تأكدي من عمل Include للجداول المرتبطة إذا لزم الأمر)

            // تصفية الفئات (بالاعتماد على الـ CategoryId المختارة)
            if (model.SelectedCategoryIds != null && model.SelectedCategoryIds.Any())
            {
                productsQuery = productsQuery.Where(p => p.CategoryIds.Any(ps => model.SelectedCategoryIds.Contains(ps)));
            }

            // تصفية البراندات (بالاعتماد على الـ BrandId المختارة)
            if (model.SelectedBrandIds != null && model.SelectedBrandIds.Any())
            {
                productsQuery = productsQuery.Where(p => model.SelectedBrandIds.Contains(p.BrandId));
            }

            // تصفية المقاسات والألوان والسعر
            if (model.SelectedSizes != null && model.SelectedSizes.Any())
            {
                productsQuery = productsQuery.Where(p => p.Variants.Select(s=>s.Size).Any(ps => model.SelectedSizes.Contains(ps)));
            }

            if (model.SelectedColors != null && model.SelectedColors.Any())
            {
                productsQuery = productsQuery.Where(p => p.Variants.Select(s => s.Color).Any(ps => model.SelectedColors.Contains(ps)));
            }

            productsQuery = productsQuery.Where(p => p.Price >= model.MinPrice && p.Price <= model.MaxPrice);

            // تطبيق منطق الترتيب (Sort)
            productsQuery = model.SelectedSort switch
            {
                "lowToHigh" => productsQuery.OrderBy(p => p.Price),
                "highToLow" => productsQuery.OrderByDescending(p => p.Price),
                //"newArrivals" => productsQuery.OrderByDescending(p => p.CreatedDate),
                _ => productsQuery.OrderByDescending(p => p.Id) // الترتيب الافتراضي
            };

            // جلب النتيجة النهائية لإرسالها للـ View لعرض الكروت
            model.Items =  productsQuery.ToList();

            return View(model);
        }

        // دالة تجريبية لمحاكاة البيانات لقاعدة البيانات
        private IQueryable<ProductDummy> GetProductsFromDatabase()
        {
            return new List<ProductDummy>().AsQueryable();
        }
    }
    public class ProductDummy 
    { 
        public string Type { get; set; }
        public List<string> Sizes { get; set; } 
        public string Color { get; set; } 
        public string Brand { get; set; } 
        public decimal Price { get; set; } 
        public DateTime CreatedDate { get; set; } 
    }

}