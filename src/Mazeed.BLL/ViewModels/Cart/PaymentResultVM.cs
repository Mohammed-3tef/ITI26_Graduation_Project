namespace Mazeed.BLL.ViewModels.Cart
{
    public class PaymentResultVM
    {
        public bool IsSuccessful { get; set; }
        public long? OrderId { get; set; }
        public string Message { get; set; } = string.Empty;
    }
}