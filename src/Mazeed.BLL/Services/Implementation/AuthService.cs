using AutoMapper;
using Mazeed.BLL.Responses;
using Mazeed.BLL.Services.Abstraction;
using Mazeed.BLL.ViewModels.User;
using Mazeed.DAL.Entities;
using Microsoft.AspNetCore.Identity;

namespace Mazeed.BLL.Services.Implementation
{
    public class AuthService : IAuthService
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly IMapper _mapper;

        public AuthService(UserManager<User> userManager, SignInManager<User> signInManager, IMapper mapper)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _mapper = mapper;
        }

        public async Task<ServiceResponse<bool>> RegisterAsync(RegisterVM model)
        {
            if (model == null)
            {
                return ServiceResponse<bool>.FailureResponse("Invalid registration request.");
            }

            var existingUser = await _userManager.FindByEmailAsync(model.Email);
            if (existingUser != null)
            {
                return ServiceResponse<bool>.FailureResponse("Email is already registered.");
            }

            existingUser = await _userManager.FindByNameAsync(model.UserName);
            if (existingUser != null)
            {
                return ServiceResponse<bool>.FailureResponse("Username is already taken.");
            }

            var user = _mapper.Map<User>(model);
            var result = await _userManager.CreateAsync(user, model.Password);
            if (!result.Succeeded)
            {
                var errors = string.Join(", ", result.Errors.Select(e => e.Description));
                return ServiceResponse<bool>.FailureResponse($"User registration failed: {errors}");
            }

            result = await _userManager.AddToRoleAsync(user, "User");
            if (!result.Succeeded)
            {
                var errors = string.Join(", ", result.Errors.Select(e => e.Description));
                return ServiceResponse<bool>.FailureResponse($"Assigning role failed: {errors}");
            }

            return ServiceResponse<bool>.SuccessResponse(true, "User registered successfully.");
        }

        public async Task<ServiceResponse<SignInResult>> LoginAsync(LoginVM model)
        {
            if (model == null)
            {
                return ServiceResponse<SignInResult>.FailureResponse("Invalid login request.");
            }

            var user = await _userManager.FindByEmailAsync(model.Email);
            if (user == null)
            {
                return ServiceResponse<SignInResult>.FailureResponse("User or password is incorrect.");
            }

            var result = await _signInManager.PasswordSignInAsync(user, model.Password, model.RememberMe, false);
            if (!result.Succeeded)
            {
                return ServiceResponse<SignInResult>.FailureResponse("User or password is incorrect.");
            }

            return ServiceResponse<SignInResult>.SuccessResponse(result, "User logged in successfully.");
        }

        public async Task<ServiceResponse<bool>> LogoutAsync()
        {
            await _signInManager.SignOutAsync();
            return ServiceResponse<bool>.SuccessResponse(true, "User logged out successfully.");
        }
    }
}
