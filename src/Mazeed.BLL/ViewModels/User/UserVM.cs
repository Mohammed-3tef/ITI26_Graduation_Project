using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace Mazeed.BLL.ViewModels.User
{
    public class UserVM
    {
        [Required(ErrorMessage = "Username is required.")]
        [Display(Name = "Username")]
        public string UserName { get; set; } = null!;

        [Required(ErrorMessage = "First name is required.")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; } = null!;

        [Required(ErrorMessage = "Last name is required.")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; } = null!;

        [Required(ErrorMessage = "Birth date is required.")]
        [Display(Name = "Birth Date")]
        public DateOnly BirthDate { get; set; }

        [Required(ErrorMessage = "Gender is required.")]
        [Display(Name = "Gender")]
        [RegularExpression("^(Male|Female)$", ErrorMessage = "Gender must be Male or Female")]
        public string Gender { get; set; } = null!;

        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; } = null!;

        [Required(ErrorMessage = "Phone number is required.")]
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; } = null!;

        // Address Fields
        [Required(ErrorMessage = "Governorate is required.")]
        public string Governorate { get; set; } = null!;
        
        [Required(ErrorMessage = "City is required.")]
        public string City { get; set; } = null!;

        [Required(ErrorMessage = "Street is required.")]
        public string Street { get; set; } = null!;

        // Holds the current filename stored in the database
        public byte[]? ExistingImage { get; set; }

        [Display(Name = "Profile Picture")]
        public IFormFile? ProfileImage { get; set; }

        public DateTime CreatedAt { get; set; }

        public IEnumerable<UserOrderVM> Orders { get; set; } = Enumerable.Empty<UserOrderVM>();
    }
}
