using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mazeed.DAL.Entities
{
    public class ItemReview : BaseEntity
    {
        public int ShopperId { get; set; }
        public Shopper Shopper { get; set; } = null!;

        public int ItemId { get; set; }
        public Item Item { get; set; } = null!;

        public string? Comment { get; set; }
        [Range(1,5)]
        public int Rate { get; set; } // Constraint: 1 to 5
    }
}
