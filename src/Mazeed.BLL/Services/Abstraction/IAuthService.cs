using Mazeed.BLL.Responses;
using Mazeed.BLL.ViewModels.User;
using Microsoft.AspNetCore.Identity;

namespace Mazeed.BLL.Services.Abstraction
{
    public interface IAuthService
    {
        Task<ServiceResponse<bool>> RegisterAsync(RegisterVM model);

        Task<ServiceResponse<SignInResult>> LoginAsync(LoginVM model);

        Task<ServiceResponse<bool>> LogoutAsync();
    }
}
