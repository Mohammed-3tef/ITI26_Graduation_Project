namespace Mazeed.BLL.ViewModels
{
    public class DiscountRuleVM
    {
        public long Id { get; set; }
        public string DiscountType { get; set; } = null!;
        public decimal DiscountValue { get; set; }
        public decimal? SpendThreshold { get; set; }
        public string? PromotionCode { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsActive { get; set; }
    }
}