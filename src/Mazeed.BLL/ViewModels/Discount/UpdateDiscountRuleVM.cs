using System.ComponentModel.DataAnnotations;

namespace Mazeed.BLL.ViewModels
{
    public class UpdateDiscountRuleVM
    {
        [MaxLength(30)]
        public string? DiscountType { get; set; }

        [Range(0, 100000)]
        public decimal? DiscountValue { get; set; }

        [Range(0, 100000)]
        public decimal? SpendThreshold { get; set; }

        [MaxLength(50)]
        public string? PromotionCode { get; set; }

        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public bool? IsActive { get; set; }
    }
}