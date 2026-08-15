using Mazeed.BLL.ViewModels.User;

namespace Mazeed.BLL.Services.Abstraction
{
    public interface IUserService
    {
        Task<IEnumerable<UserVM>> GetAllUsersAsync();
        Task<UserVM> GetUserByEmailAsync(string email);
        Task<UserVM> GetUserByNameAsync(string name);
        Task<UserVM> GetUserByPhoneNumberAsync(string phoneNumber);
    }
}
