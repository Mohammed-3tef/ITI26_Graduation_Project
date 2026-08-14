using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mazeed.DAL.Entities
{
    public class Notification : BaseEntity
    {
        public string Title { get; set; } = string.Empty;
        public string Msg { get; set; } = string.Empty;
        public string Type { get; set; } = string.Empty; // OrderStatus, Alert, Promotion

        // Navigation Properties
        public ICollection<UserNotification> UserNotifications { get; set; } = new List<UserNotification>();
        
    }
}
