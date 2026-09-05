namespace Mazeed.BLL.ViewModels
{
    public class CartVM
    {
        public List<CartItemVM> Items { get; set; } = new();
        public int TotalItemsCount { get; set; }
        public decimal Subtotal { get; set; }
    }
}