using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
namespace Mazeed.DAL.Entities
{
    public class ShopperFavorite
    {
        [ForeignKey(nameof(Shopper))]
        public long UserId { get; set; }
        public User Shopper { get; set; } = null!;

        [ForeignKey(nameof(Item))]
        public long ItemId { get; set; }
        public Item Item { get; set; } = null!;
    }
}
