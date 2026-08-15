using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace Mazeed.BLL.ViewModels.User
{
    public class UserVM
    {
        [Required]
        [Display(Name = "Username")]
        public string UserName { get; set; } = null!;

        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; } = null!;

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; } = null!;

        [Required]
        [Display(Name = "Birth Date")]
        public DateOnly BirthDate { get; set; }

        [Required]
        [Display(Name = "Gender")]
        [RegularExpression("^(Male|Female)$", ErrorMessage = "Gender must be Male or Female")]
        public string Gender { get; set; } = null!;

        [Required]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; } = null!;

        [Required]
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; } = null!;

        // Address Fields
        [Required]
        public string Governorate { get; set; } = null!;
        
        [Required]
        public string City { get; set; } = null!;

        [Required]
        public string Street { get; set; } = null!;

        // Holds the current filename stored in the database
        public string? ImageUrl { get; set; }

        [Display(Name = "Profile Picture")]
        public IFormFile? ProfileImage { get; set; }
    }
}
