using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
using System.Reflection;

namespace Mazeed.DAL.Entities
{
    public class User : IdentityUser<long>, IBaseEntity
    {
        [Required, MaxLength(50)]
        public string FirstName { get; set; } = string.Empty;

        [Required, MaxLength(50)]
        public string LastName { get; set; } = string.Empty;

        public byte[]? ProfileImage { get; set; }

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

        public void Create(User user, string createdBy)
        {
            FirstName = user.FirstName ?? FirstName;
            LastName = user.LastName ?? LastName;
            PhoneNumber = user.PhoneNumber ?? PhoneNumber;
            BirthDate = user.BirthDate ?? BirthDate;
            Gender = user.Gender ?? Gender;
            ProfileImage = user.ProfileImage ?? ProfileImage;
            CityId = user.CityId ?? CityId;
            City = user.City ?? City;
            Street = user.Street ?? Street;
            CreatedBy = createdBy;
            CreatedAt = DateTime.UtcNow;
        }

        public void Update(string? firstName, string? lastName, string? phoneNumber, DateOnly? birthDate, string? gender, byte[]? profileImage, long? cityId, City? city, string? street, string? updatedBy)
        {
            FirstName = firstName ?? FirstName;
            LastName = lastName ?? LastName;
            PhoneNumber = phoneNumber ?? PhoneNumber;
            BirthDate = birthDate ?? BirthDate;
            Gender = gender == "Male" ? 'M' : 'F';
            ProfileImage = profileImage ?? ProfileImage;
            CityId = cityId ?? CityId;
            City = city ?? City;
            Street = street ?? Street;
            UpdatedBy = updatedBy ?? UpdatedBy;
            UpdatedAt = DateTime.UtcNow;
        }

        public void Delete(string deletedBy)
        {
            DeletedBy = deletedBy;
            DeletedAt = DateTime.UtcNow;
            IsDeleted = true;
        }
    }
}