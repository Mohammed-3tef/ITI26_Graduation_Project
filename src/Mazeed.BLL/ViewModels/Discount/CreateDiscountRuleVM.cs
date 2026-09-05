using System.ComponentModel.DataAnnotations;

namespace Mazeed.BLL.ViewModels
{
    public class CreateDiscountRuleVM
    {
        [Required, MaxLength(30)]
        public string DiscountType { get; set; } = "Percentage";

        [Required, Range(0, 100000)]
        public decimal DiscountValue { get; set; }

        [Range(0, 100000)]
        public decimal? SpendThreshold { get; set; }

        [MaxLength(50)]
        public string? PromotionCode { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        public DateTime EndDate { get; set; }

        public bool IsActive { get; set; } = true;
    }
}