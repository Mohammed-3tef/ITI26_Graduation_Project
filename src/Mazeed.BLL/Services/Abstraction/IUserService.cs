using Mazeed.BLL.Responses;
using Mazeed.BLL.ViewModels.User;

namespace Mazeed.BLL.Services.Abstraction
{
    public interface IUserService
    {
        Task<ServiceResponse<IEnumerable<UserVM>>> GetAllUsersAsync();
        Task<ServiceResponse<UserVM?>> GetUserByEmailAsync(string email);
        Task<ServiceResponse<UserVM?>> GetUserByNameAsync(string name);
        Task<ServiceResponse<UserVM?>> GetUserByPhoneNumberAsync(string phoneNumber);
        Task<ServiceResponse<bool>> UpdateUserProfileAsync(UserVM model);
    }
}
