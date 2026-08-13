using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Mazeed.DAL.Entities
{
    public class Admin : IdentityUser<int>
    {
        [MaxLength(50)]
        public string FirstName { get; set; } = string.Empty;
        [MaxLength(50)]
        public string LastName { get; set; } = string.Empty;

        // Navigation Properties
        public ICollection<AdminNotification> Notifications { get; set; } = new List<AdminNotification>();
    }
}
