using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mazeed.DAL.Entities
{
    public class ItemReview : BaseEntity
    {
        [ForeignKey(nameof(Shopper))]
        public long UserId { get; set; }
        public User Shopper { get; set; } = null!;

        [ForeignKey(nameof(Item))]
        public long ItemId { get; set; }
        public Item Item { get; set; } = null!;

        public string? Comment { get; set; }
        [Range(1,5)]
        public int Rate { get; set; } // Constraint: 1 to 5
    }
}
