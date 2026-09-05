using System.ComponentModel.DataAnnotations;

namespace Mazeed.BLL.ViewModels
{
    public class AddToCartVM
    {
        [Required]
        public long ItemVariantId { get; set; }

        [Range(1, 1000)]
        public int Quantity { get; set; } = 1;
    }
}