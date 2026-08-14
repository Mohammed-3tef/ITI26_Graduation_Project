using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Mazeed.DAL.Entities
{
    public class ItemCategory
    {
        [ForeignKey(nameof(Item))]
        public long ItemId { get; set; }
        public Item Item { get; set; } = null!;

        [ForeignKey(nameof(Category))]
        public long CategoryId { get; set; }
        public Category Category { get; set; } = null!;
    }
}
