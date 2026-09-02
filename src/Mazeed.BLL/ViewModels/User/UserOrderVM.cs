namespace Mazeed.BLL.ViewModels.User
{
    public class UserOrderVM
    {
        public long Id { get; set; }
        public DateTime OrderingDate { get; set; }
        public decimal TotalPrice { get; set; }
        public string Status { get; set; } = string.Empty;
        public int ItemsCount { get; set; }
        public List<UserOrderDetailVM> Items { get; set; } = new();
    }

    public class UserOrderDetailVM
    {
        public string ItemName { get; set; } = string.Empty;
        public string SKU { get; set; } = string.Empty;
        public string Color { get; set; } = string.Empty;
        public string Size { get; set; } = string.Empty;
        public int Quantity { get; set; }
        public decimal PricePerItem { get; set; }
        public decimal TotalPrice => Quantity * PricePerItem;
    }
}