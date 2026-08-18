using System.ComponentModel.DataAnnotations;

namespace Mazeed.BLL.ViewModels
{
    public class ApplyPromoCodeVM
    {
        [MaxLength(50)]
        public string? PromotionCode { get; set; }

        [Required, Range(0.01, double.MaxValue)]
        public decimal CartSubtotal { get; set; }
    }
}