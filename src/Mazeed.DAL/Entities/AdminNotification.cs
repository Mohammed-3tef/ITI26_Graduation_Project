using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mazeed.DAL.Entities
{
    public class AdminNotification
    {
        public int AdminId { get; set; }
        public Admin Admin { get; set; } = null!;

        public int NotificationId { get; set; }
        public Notification Notification { get; set; } = null!;

        public bool IsRead { get; set; } = false;
    }
}
