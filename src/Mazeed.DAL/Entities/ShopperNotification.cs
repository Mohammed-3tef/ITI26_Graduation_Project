using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mazeed.DAL.Entities
{
    public class ShopperNotification
    {
        public int ShopperId { get; set; }
        public Shopper Shopper { get; set; } = null!;

        public int NotificationId { get; set; }
        public Notification Notification { get; set; } = null!;

        public bool IsRead { get; set; } = false;
    }
}
