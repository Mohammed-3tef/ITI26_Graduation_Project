using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mazeed.DAL.Entities
{
    public class ItemVariant : BaseEntity
    {
        [Required, MaxLength(50)]
        public string SKU { get; set; } = string.Empty;

        [Required, MaxLength(30)]
        public string Color { get; set; } = string.Empty;

        [Required, MaxLength(20)]
        public string Size { get; set; } = string.Empty;

        [Range(0, int.MaxValue)]
        [Column(TypeName = "decimal(18,2)")]
        public decimal PriceAdjustment { get; set; } = 0;

        [Range(0, 100000)]
        public int StockQuantity { get; set; }

        [Range(0, 1000)]
        public int LowStockThreshold { get; set; } = 5;

        // Foreign Key
        public int ItemId { get; set; }
        public Item Item { get; set; } = null!;

        // Navigation Properties
        public ICollection<ShopperCart> CartItems { get; set; } = new List<ShopperCart>();
        public ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();
    }
}
