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

        public StoreController(
            IItemService itemService,
            ICategoryService categoryService,
            IBrandService brandService)
        {
            _itemService = itemService;
            _categoryService = categoryService;
            _brandService = brandService;
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

            var items = itemsResponse.Data ?? new List<ItemVM>();

            // 1. Search Query Filter
            if (!string.IsNullOrWhiteSpace(searchQuery))
            {
                items = items.Where(i => i.Name.Contains(searchQuery, StringComparison.OrdinalIgnoreCase));
            }

            // 2. Brand Filter
            if (brandId.HasValue)
            {
                items = items.Where(i => i.BrandId == brandId.Value);
            }

            // 3. Category Filter
            if (categoryId.HasValue)
            {
                items = items.Where(i => i.CategoryIds != null && i.CategoryIds.Contains(categoryId.Value));
            }

            // 4. Price Filters
            if (minPrice.HasValue)
            {
                items = items.Where(i => i.Price >= minPrice.Value);
            }
            if (maxPrice.HasValue)
            {
                items = items.Where(i => i.Price <= maxPrice.Value);
            }

            // 5. Sorting
            items = sortBy switch
            {
                "price_low_high" => items.OrderBy(i => i.Price),
                "price_high_low" => items.OrderByDescending(i => i.Price),
                "name_asc" => items.OrderBy(i => i.Name),
                "name_desc" => items.OrderByDescending(i => i.Name),
                _ => items
            };

            var viewModel = new ShopCatalogVM
            {
                SearchQuery = searchQuery,
                SortBy = sortBy,
                BrandId = brandId,
                CategoryId = categoryId,
                MinPrice = minPrice,
                MaxPrice = maxPrice,
                Items = items.ToList(),
                Brands = brandsResponse.Data ?? new List<BrandVM>(),
                Categories = categoriesResponse.Data ?? new List<CategoryVM>()
            };

            return View(viewModel);
        }
    }
}