using Mazeed.BLL.ViewModels;

namespace Mazeed.BLL.ViewModels
{
    public class ShopCatalogVM
    {
        // Search & Filter Parameters
        public string? SearchQuery { get; set; }
        public string? SortBy { get; set; }
        public long? BrandId { get; set; }
        public long? CategoryId { get; set; }
        public decimal? MinPrice { get; set; }
        public decimal? MaxPrice { get; set; }

        // Data Lists
        public IEnumerable<ItemVM> Items { get; set; } = new List<ItemVM>();
        public IEnumerable<BrandVM> Brands { get; set; } = new List<BrandVM>();
        public IEnumerable<CategoryVM> Categories { get; set; } = new List<CategoryVM>();

        public int TotalCount => Items?.Count() ?? 0;
    }
}