using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
        public string? ImageUrl { get; set; }

        public DateOnly? BirthDate { get; set; }
        public char? Gender { get; set; }

        // Shopper Address
        [ForeignKey(nameof(City))]
        public long? CityId { get; set; }
        public City? City { get; set; }

        [MaxLength(150)]
        public string? Street { get; set; } 

        // Audit Fields
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public string CreatedBy { get; set; } = null!;
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