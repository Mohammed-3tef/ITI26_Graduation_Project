namespace Mazeed.BLL.ViewModels
{
    public class WishlistItemVM
    {
        public long ItemId { get; set; }
        public string ItemName { get; set; } = null!;
        public string? BrandName { get; set; }
        public decimal Price { get; set; }
        public string? ImageUrl { get; set; }
        public bool InStock { get; set; }
    }
}