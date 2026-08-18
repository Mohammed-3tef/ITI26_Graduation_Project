namespace Mazeed.BLL.ViewModels
{
    public class DiscountResultVM
    {
        public bool Applied { get; set; }
        public long? DiscountRuleId { get; set; }
        public string? PromotionCode { get; set; }
        public string? DiscountType { get; set; }
        public decimal? DiscountValue { get; set; }
        public decimal DiscountAmount { get; set; }
        public decimal Subtotal { get; set; }
        public decimal FinalTotal { get; set; }
        public string Message { get; set; } = null!;
    }
}