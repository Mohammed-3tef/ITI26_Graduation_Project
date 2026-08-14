using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mazeed.DAL.Entities
{
    public class OrderDetail : BaseEntity
    {
        [Range(1, 1000)]
        public int Quantity { get; set; }

        [Required, Range(0, 1000000)]
        [Column(TypeName = "decimal(18,2)")]
        public decimal PricePerItem { get; set; }

        // Derived Property
        [NotMapped]
        public decimal TotalPrice => Quantity * PricePerItem;

        // Foreign Keys
        public int OrderId { get; set; }
        public Order Order { get; set; } = null!;

        public int ItemVariantId { get; set; }
        public ItemVariant ItemVariant { get; set; } = null!;
    }
}
