namespace Mazeed.BLL.ViewModels.Admin
{
    public class SalesOrderVM
    {
        public long Id { get; set; }
        public DateTime OrderingDate { get; set; }
        public string CustomerName { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string ShippingAddress { get; set; } = string.Empty;
        public decimal TotalPrice { get; set; }
        public string Status { get; set; } = string.Empty;
        public string PaymentStatus { get; set; } = string.Empty;
        public int ItemsCount { get; set; }
        public List<SalesOrderItemVM> Items { get; set; } = new();
    }

    public class SalesOrderItemVM
    {
        public string ItemName { get; set; } = string.Empty;
        public string SKU { get; set; } = string.Empty;
        public string Variant { get; set; } = string.Empty;
        public int Quantity { get; set; }
        public decimal PricePerItem { get; set; }
        public decimal LineTotal => Quantity * PricePerItem;
    }
}