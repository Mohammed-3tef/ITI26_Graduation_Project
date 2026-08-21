using Mazeed.BLL.Responses;
using Mazeed.BLL.Services.Abstraction;
using Mazeed.BLL.ViewModels;
using Mazeed.BLL.ViewModels.User;
using Mazeed.DAL.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Mazeed.BLL.Services.Implementation
{
    public class RoleService : IRoleService
    {
        private readonly RoleManager<IdentityRole<long>> _roleManager;
        private readonly UserManager<User> _userManager;

        public RoleService(RoleManager<IdentityRole<long>> roleManager, UserManager<User> userManager)
        {
            _roleManager = roleManager;
            _userManager = userManager;
        }

        public async Task<ServiceResponse<IEnumerable<RoleVM>>> GetAllRolesAsync()
        {
            var roles = await _roleManager.Roles.ToListAsync();
            var roleList = new List<RoleVM>();

            foreach (var role in roles)
            {
                var usersInRole = await _userManager.GetUsersInRoleAsync(role.Name!);
                roleList.Add(new RoleVM
                {
                    Id = role.Id.ToString(),
                    Name = role.Name!,
                    UsersCount = usersInRole.Count
                });
            }

            return ServiceResponse<IEnumerable<RoleVM>>.SuccessResponse(roleList, "Roles loaded.");
        }

        public async Task<ServiceResponse<bool>> CreateRoleAsync(string roleName)
        {
            if (await _roleManager.RoleExistsAsync(roleName))
                return ServiceResponse<bool>.FailureResponse("Role already exists.");

            var result = await _roleManager.CreateAsync(new IdentityRole<long>(roleName));
            return result.Succeeded
                ? ServiceResponse<bool>.SuccessResponse(true, "Role created.")
                : ServiceResponse<bool>.FailureResponse("Failed to create role.");
        }

        public async Task<ServiceResponse<bool>> DeleteRoleAsync(string roleName)
        {
            var role = await _roleManager.FindByNameAsync(roleName);
            if (role == null)
                return ServiceResponse<bool>.FailureResponse("Role not found.");

            var result = await _roleManager.DeleteAsync(role);
            return result.Succeeded
                ? ServiceResponse<bool>.SuccessResponse(true, "Role deleted.")
                : ServiceResponse<bool>.FailureResponse("Failed to delete role.");
        }

        public async Task<ServiceResponse<IEnumerable<UserRoleVM>>> GetUsersWithRolesAsync()
        {
            var users = await _userManager.Users.ToListAsync();
            var allRoles = await _roleManager.Roles.Select(r => r.Name!).ToListAsync();
            var resultList = new List<UserRoleVM>();

            foreach (var user in users)
            {
                var roles = await _userManager.GetRolesAsync(user);
                resultList.Add(new UserRoleVM
                {
                    UserId = user.Id.ToString(),
                    UserEmail = user.Email!,
                    UserName = $"{user.FirstName} {user.LastName}",
                    AssignedRoles = roles.ToList(),
                    AllRoles = allRoles
                });
            }

            return ServiceResponse<IEnumerable<UserRoleVM>>.SuccessResponse(resultList, "Loaded user roles.");
        }

        public async Task<ServiceResponse<bool>> UpdateUserRolesAsync(string userEmail, List<string> selectedRoles)
        {
            var user = await _userManager.FindByEmailAsync(userEmail);
            if (user == null)
                return ServiceResponse<bool>.FailureResponse("User not found.");

            var currentRoles = await _userManager.GetRolesAsync(user);
            selectedRoles ??= new List<string>();

            var removeResult = await _userManager.RemoveFromRolesAsync(user, currentRoles);
            if (!removeResult.Succeeded)
                return ServiceResponse<bool>.FailureResponse("Failed to clear existing roles.");

            var addResult = await _userManager.AddToRolesAsync(user, selectedRoles);
            return addResult.Succeeded
                ? ServiceResponse<bool>.SuccessResponse(true, "User roles updated.")
                : ServiceResponse<bool>.FailureResponse("Failed to assign new roles.");
        }
    }
}
