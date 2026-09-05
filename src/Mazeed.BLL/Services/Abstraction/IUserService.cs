using Mazeed.BLL.Responses;
using Mazeed.BLL.ViewModels.User;
using Microsoft.AspNetCore.Http;

namespace Mazeed.BLL.Services.Abstraction
{
    public interface IUserService
    {
        Task<ServiceResponse<IEnumerable<UserVM>>> GetAllUsersAsync();
        Task<ServiceResponse<UserVM?>> GetUserByEmailAsync(string email);
        Task<ServiceResponse<UserVM?>> GetUserByNameAsync(string name);
        Task<ServiceResponse<UserVM?>> GetUserByPhoneNumberAsync(string phoneNumber);
        Task<ServiceResponse<IEnumerable<UserOrderVM>>> GetUserOrdersAsync(long userId);
        Task<ServiceResponse<bool>> CreateUserAsync(UserVM model);
        Task<ServiceResponse<bool>> UpdateUserProfileAsync(UserVM model);
        Task<ServiceResponse<bool>> UpdateUserProfileImageAsync(string username, IFormFile image);
        Task<ServiceResponse<bool>> DeleteUserByEmailAsync(string email);
    }
}
