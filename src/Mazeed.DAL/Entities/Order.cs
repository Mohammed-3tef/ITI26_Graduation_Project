using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mazeed.DAL.Entities
{
    public class Order : BaseEntity
    {
        public DateTime OrderingDate { get; set; } = DateTime.UtcNow;

        [Required, Range(0, 1000000)]
        [Column(TypeName = "decimal(18,2)")]
        public decimal TotalPrice { get; set; }

        [Required, MaxLength(20)]
        public string Status { get; set; } = "Pending";

        [Range(0, 100000)]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Discount { get; set; } = 0;

        [Range(0, 10000)]
        [Column(TypeName = "decimal(18,2)")]
        public decimal ShippingFee { get; set; } = 0;

        // Foreign Keys
        [ForeignKey(nameof(Shopper))]
        public long UserId { get; set; }
        public User Shopper { get; set; } = null!;

        [ForeignKey(nameof(DiscountRule))]
        public long? DiscountRuleId { get; set; }
        public DiscountRule? DiscountRule { get; set; }

        // Navigation Properties
        public Payment? Payment { get; set; }
        public Shipment? Shipment { get; set; }
        public ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();
    }
}
