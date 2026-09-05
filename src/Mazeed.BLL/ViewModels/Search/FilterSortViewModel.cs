namespace Mazeed.BLL.ViewModels.Search
{
    public class FilterSortViewModel
    {
        public string? SearchQuery { get; set; } // Added to retain navbar searches
        public int TotalCount { get; set; }      // Added to fix Apply (@Model.TotalCount)

        public string SelectedSort { get; set; } = "recommended";
        public List<long> SelectedCategoryIds { get; set; } = new();
        public List<string> SelectedSizes { get; set; } = new();
        public List<string> SelectedColors { get; set; } = new();
        public List<long> SelectedBrandIds { get; set; } = new();

        // Change to nullable decimals to prevent slider resets on fresh loads
        public decimal? MinPrice { get; set; } = 0;
        public decimal? MaxPrice { get; set; } = 100000000;

        public List<ItemVM> Items { get; set; } = new List<ItemVM>();

        public List<CategoryVM> AvailableCategories { get; set; } = new();
        public List<string> AvailableSizes { get; set; } = new();
        public List<ColorItem> AvailableColors { get; set; } = new();
        public List<BrandVM> AvailableBrands { get; set; } = new();
    }
}
