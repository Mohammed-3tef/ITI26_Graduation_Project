using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mazeed.DAL.Entities
{
    public class Payment : BaseEntity
    {
        [Required, MaxLength(30)]
        public string Method { get; set; } = string.Empty;

        [Required, Range(0, 1000000)]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Amount { get; set; }

        [Required, MaxLength(20)]
        public string Status { get; set; } = "Pending";

        [MaxLength(100)]
        public string? TransactionId { get; set; }

        public DateTime? PaidAt { get; set; }

        // Foreign Key
        public int OrderId { get; set; }
        public Order Order { get; set; } = null!;
    }
}
