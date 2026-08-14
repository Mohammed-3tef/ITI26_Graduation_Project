using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mazeed.DAL.Entities
{
    public class DiscountRule : BaseEntity
    {
        [Required, MaxLength(30)]
        public string DiscountType { get; set; } = "Percentage";

        [Required, Range(0, 100000)]
        [Column(TypeName = "decimal(18,2)")]
        public decimal DiscountValue { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal? SpendThreshold { get; set; }

        [MaxLength(50)]
        public string? PromotionCode { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsActive { get; set; } = true;

        // Navigation Properties
        public ICollection<Order> Orders { get; set; } = new List<Order>();
    }
}
