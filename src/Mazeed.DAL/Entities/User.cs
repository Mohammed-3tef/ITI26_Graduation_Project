using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace Mazeed.DAL.Entities
{
    public class User : IdentityUser<long>, IBaseEntity
    {
        [Required, MaxLength(50)]
        public string FirstName { get; set; } = string.Empty;

        [Required, MaxLength(50)]
        public string LastName { get; set; } = string.Empty;

        [MaxLength(500)]
        public string? ProfilePicture { get; set; }

        public DateOnly? Birthdate { get; set; }
        public char? Gender { get; set; }

        // Address (الخاص بالشوبر)
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

        // Audit Fields
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public string CreatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string? UpdatedBy { get; set; }
        public bool IsDeleted { get; set; } = false;
        public DateTime? DeletedAt { get; set; }
        public string? DeletedBy { get; set; }

        // Navigation Properties 
        public ICollection<Order> Orders { get; set; } = new List<Order>();
        public ICollection<ShopperCart> CartItems { get; set; } = new List<ShopperCart>();
        public ICollection<ShopperFavorite> Favorites { get; set; } = new List<ShopperFavorite>();
        public ICollection<ItemReview> Reviews { get; set; } = new List<ItemReview>();
        public ICollection<Notification> Notifications { get; set; } = new List<Notification>();
    }
}