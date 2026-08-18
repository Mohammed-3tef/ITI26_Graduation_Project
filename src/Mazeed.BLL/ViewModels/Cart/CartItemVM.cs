namespace Mazeed.BLL.ViewModels
{
    public class CartItemVM
    {
        public long ItemVariantId { get; set; }
        public long ItemId { get; set; }
        public string ItemName { get; set; } = null!;
        public string? BrandName { get; set; }
        public string SKU { get; set; } = null!;
        public string Color { get; set; } = null!;
        public string Size { get; set; } = null!;
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
        public decimal LineTotal { get; set; }
        public int StockQuantity { get; set; }
        public string? ImageUrl { get; set; }
    }
}