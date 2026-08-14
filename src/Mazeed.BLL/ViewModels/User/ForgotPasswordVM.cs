using System.ComponentModel.DataAnnotations;

namespace Mazeed.BLL.ViewModels.User
{
    public class ForgotPasswordVM
    {
        [Required, EmailAddress]
        public string Email { get; set; } = string.Empty;
    }
}
