using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
namespace Mazeed.DAL.Entities
{
    public class UserNotification
    {
        [ForeignKey(nameof(User))]
        public long UserId { get; set; }
        public User User { get; set; } = null!;

        [ForeignKey(nameof(Notification))]
        public long NotificationId { get; set; }
        public Notification Notification { get; set; } = null!;

        public bool IsRead { get; set; } = false;
    }
}
