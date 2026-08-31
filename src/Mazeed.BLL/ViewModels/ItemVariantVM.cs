using System.ComponentModel.DataAnnotations;

namespace Mazeed.BLL.ViewModels
{
    public class ItemVariantVM
    {
        public long Id { get; set; }

        [Required(ErrorMessage = "SKU is required.")]
        [StringLength(50, ErrorMessage = "SKU cannot exceed 50 characters.")]
        public string SKU { get; set; } = string.Empty;

        [Required(ErrorMessage = "Color is required.")]
        [StringLength(30, ErrorMessage = "Color cannot exceed 30 characters.")]
        public string Color { get; set; } = string.Empty;

        [Required(ErrorMessage = "Size is required.")]
        [StringLength(20, ErrorMessage = "Size cannot exceed 20 characters.")]
        public string Size { get; set; } = string.Empty;

        [Range(0, (double)decimal.MaxValue, ErrorMessage = "Price adjustment must be non-negative.")]
        [Display(Name = "Price Adjustment")]
        public decimal PriceAdjustment { get; set; } = 0;

        [Range(0, 100000, ErrorMessage = "Stock quantity must be between 0 and 100,000.")]
        [Display(Name = "Stock Quantity")]
        public int StockQuantity { get; set; }

        [Range(0, 1000, ErrorMessage = "Low stock threshold must be between 0 and 1,000.")]
        [Display(Name = "Low Stock Threshold")]
        public int LowStockThreshold { get; set; } = 5;

        [Required(ErrorMessage = "Please select an Item.")]
        [Display(Name = "Item")]
        public long ItemId { get; set; }

        [Display(Name = "Item Name")]
        public string? ItemName { get; set; }

        public List<string> Photos { get; set; } = new List<string>();
    }
}