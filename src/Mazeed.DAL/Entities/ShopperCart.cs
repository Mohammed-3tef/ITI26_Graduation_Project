using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
namespace Mazeed.DAL.Entities
{
    public class ShopperCart
    {
        [ForeignKey(nameof(Shopper))]
        public long UserId { get; set; }
        public User Shopper { get; set; } = null!;

        [ForeignKey(nameof(ItemVariant))]
        public long ItemVariantId { get; set; }
        public ItemVariant ItemVariant { get; set; } = null!;

        [Range(1,1000)]
        public int Quantity { get; set; }
    }
}
