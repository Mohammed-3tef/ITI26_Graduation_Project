using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mazeed.DAL.Entities
{
    public class ShopperFavorite
    {
        public int ShopperId { get; set; }
        public Shopper Shopper { get; set; } = null!;

        public int ItemId { get; set; }
        public Item Item { get; set; } = null!;
    }
}
