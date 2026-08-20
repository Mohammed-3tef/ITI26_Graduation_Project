using System.ComponentModel.DataAnnotations;

namespace Mazeed.BLL.ViewModels
{
    public class ItemVariantVM
    {
        public long Id { get; set; }

        [Required(ErrorMessage = "Variant name is required.")]
        [StringLength(100, ErrorMessage = "Variant name cannot exceed 100 characters.")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Variant value is required.")]
        [StringLength(100, ErrorMessage = "Variant value cannot exceed 100 characters.")]
        public string Value { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please select an Item.")]
        [Display(Name = "Item")]
        public long ItemId { get; set; }

        public string? ItemName { get; set; }
    }
}