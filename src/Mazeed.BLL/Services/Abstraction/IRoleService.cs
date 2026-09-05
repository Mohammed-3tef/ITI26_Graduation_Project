using Mazeed.BLL.Responses;
using Mazeed.BLL.ViewModels;
using Mazeed.BLL.ViewModels.User;

namespace Mazeed.BLL.Services.Abstraction
{
    public interface IRoleService
    {
        Task<ServiceResponse<IEnumerable<RoleVM>>> GetAllRolesAsync();
        Task<ServiceResponse<bool>> CreateRoleAsync(string roleName);
        Task<ServiceResponse<bool>> DeleteRoleAsync(string roleName);
        Task<ServiceResponse<IEnumerable<UserRoleVM>>> GetUsersWithRolesAsync();
        Task<ServiceResponse<bool>> UpdateUserRolesAsync(string userEmail, List<string> roles);
    }
}
