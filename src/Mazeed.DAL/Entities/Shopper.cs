using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Mazeed.DAL.Entities
{
    public class Shopper : IdentityUser<int>
    {
        [Required, MaxLength(50)]
        public string FirstName { get; set; } = string.Empty;

        [Required, MaxLength(50)]
        public string LastName { get; set; } = string.Empty;

        [MaxLength(500)]
        public string? ProfilePicture { get; set; }

        public DateTime? Birthdate { get; set; }

        // Address (Nullable for initial signup)
        [MaxLength(150)]
        public string? Street { get; set; }

        [MaxLength(50)]
        public string? City { get; set; }

        [MaxLength(50)]
        public string? Country { get; set; }

        // Preferences
        [Required, MaxLength(5)]
        public string Language { get; set; } = "en";

        [Required, MaxLength(10)]
        public string Theme { get; set; } = "light";

        // Navigation Properties
        public ICollection<Order> Orders { get; set; } = new List<Order>();
        public ICollection<ShopperCart> CartItems { get; set; } = new List<ShopperCart>();
        public ICollection<ShopperFavorite> Favorites { get; set; } = new List<ShopperFavorite>();
        public ICollection<ItemReview> Reviews { get; set; } = new List<ItemReview>();
        public ICollection<ShopperNotification> Notifications { get; set; } = new List<ShopperNotification>();
    }
}
