using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mazeed.DAL.Entities
{
    public class ShopperCart
    {
        public int ShopperId { get; set; }
        public Shopper Shopper { get; set; } = null!;

        public int ItemVariantId { get; set; }
        public ItemVariant ItemVariant { get; set; } = null!;

        [Range(1,1000)]
        public int Quantity { get; set; }
    }
}
