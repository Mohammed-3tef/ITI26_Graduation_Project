using Mazeed.BLL.Responses;
using Mazeed.BLL.ViewModels.User;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;

namespace Mazeed.BLL.Services.Abstraction
{
    public interface IAuthService
    {
        Task<ServiceResponse<bool>> RegisterAsync(RegisterVM model, string origin);
        Task<ServiceResponse<SignInResult>> LoginAsync(LoginVM model, string origin);
        Task<ServiceResponse<bool>> LogoutAsync();

        // Email Confirmation
        Task<ServiceResponse<bool>> ConfirmEmailAsync(string userId, string token);

        // Password Recovery
        Task<ServiceResponse<string>> GeneratePasswordResetTokenAsync(string email);
        Task<ServiceResponse<bool>> ResetPasswordAsync(ResetPasswordVM model);

        // External Auth
        AuthenticationProperties ConfigureExternalAuthenticationProperties(string provider, string redirectUrl);
        Task<ServiceResponse<ExternalLoginInfo>> GetExternalLoginInfoAsync();
        Task<ServiceResponse<SignInResult>> ExternalLoginSignInAsync(ExternalLoginInfo info);
        Task<ServiceResponse<bool>> RegisterExternalUserAsync(ExternalLoginInfo info, string userName);
    }
}