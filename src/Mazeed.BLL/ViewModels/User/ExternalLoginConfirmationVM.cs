using System.ComponentModel.DataAnnotations;

namespace Mazeed.BLL.ViewModels.User
{
    public class ExternalLoginConfirmationVM
    {
        [Required, EmailAddress]
        public string Email { get; set; } = string.Empty;

        [Required]
        public string UserName { get; set; } = string.Empty;
    }
}
