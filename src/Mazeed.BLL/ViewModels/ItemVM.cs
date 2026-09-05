using System.ComponentModel.DataAnnotations;

namespace Mazeed.BLL.ViewModels
{
    public class ItemVM
    {
        public long Id { get; set; }

        [Required(ErrorMessage = "Item name is required.")]
        [StringLength(100)]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Price is required.")]
        [Range(0.01, 999999.99)]
        public decimal Price { get; set; }
        public decimal? OldPrice { get; set; }

        [Required(ErrorMessage = "Please select a Brand.")]
        [Display(Name = "Brand")]
        public long BrandId { get; set; }
        public string? BrandName { get; set; }

        // Selected Category IDs for Create/Edit
        [Required(ErrorMessage = "Please select at least one Category.")]
        [Display(Name = "Categories")]
        public List<long> CategoryIds { get; set; } = new List<long>();

        // Selected Category Names for Index/Details/Delete
        public List<string> CategoryNames { get; set; } = new List<string>();
        public List<string> Photos { get; set; } = new List<string>();
        public List<ItemVariantVM> Variants { get; set; } = new List<ItemVariantVM>();
    }
}
