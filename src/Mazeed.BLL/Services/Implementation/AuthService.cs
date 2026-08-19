using AutoMapper;
using Mazeed.BLL.Responses;
using Mazeed.BLL.Services.Abstraction;
using Mazeed.BLL.ViewModels.User;
using Mazeed.DAL.Entities;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;

namespace Mazeed.BLL.Services.Implementation
{
    public class AuthService : IAuthService
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly IMapper _mapper;
        private readonly IEmailService _emailService;

        public AuthService(
            UserManager<User> userManager,
            SignInManager<User> signInManager,
            IMapper mapper,
            IEmailService emailService)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _mapper = mapper;
            _emailService = emailService;
        }

        #region Registration & Login & Logout
        public async Task<ServiceResponse<bool>> RegisterAsync(RegisterVM model, string origin)
        {
            if (model == null)
                return ServiceResponse<bool>.FailureResponse("Invalid registration request.");

            var existingEmail = await _userManager.FindByEmailAsync(model.Email);
            if (existingEmail != null)
                return ServiceResponse<bool>.FailureResponse("Email is already registered.");

            var existingUserName = await _userManager.FindByNameAsync(model.UserName);
            if (existingUserName != null)
                return ServiceResponse<bool>.FailureResponse("Username is already taken.");

            var user = _mapper.Map<User>(model);
            //user.CreatedBy = model.UserName;
            user.Create(_mapper.Map<User>(model), model.UserName);
            var result = await _userManager.CreateAsync(user, model.Password);
            if (!result.Succeeded)
            {
                var errors = string.Join(", ", result.Errors.Select(e => e.Description));
                return ServiceResponse<bool>.FailureResponse($"Registration failed: {errors}");
            }

            await _userManager.AddToRoleAsync(user, "User");

            // Email Confirmation Flow
            var token = await _userManager.GenerateEmailConfirmationTokenAsync(user);
            var confirmationLink = $"{origin}/Auth/ConfirmEmail?userId={user.Id}&token={Uri.EscapeDataString(token)}";

            try
            {
                var placeholders = new Dictionary<string, string>
                {
                    { "UserName", user.UserName ?? user.Email! },
                    { "ConfirmationLink", confirmationLink }
                };

                var emailBody = await _emailService.GetEmailTemplateAsync("ConfirmEmailTemplate", placeholders);
                await _emailService.SendEmailAsync(user.Email!, "Confirm Your Email - Mazeed+", emailBody);
            }
            catch (Exception ex)
            {
                return ServiceResponse<bool>.SuccessResponse(true, "Registration successful, but we couldn't send the confirmation email right now.");
            }

            return ServiceResponse<bool>.SuccessResponse(true, "Registration successful. Please check your email to confirm your account.");
        }

        public async Task<ServiceResponse<SignInResult>> LoginAsync(LoginVM model, string origin) // 👈 أضفنا origin
        {
            if (model == null)
                return ServiceResponse<SignInResult>.FailureResponse("Invalid login request.");

            var user = await _userManager.FindByEmailAsync(model.Email);
            if (user == null)
                return ServiceResponse<SignInResult>.FailureResponse("Invalid email or password.");

            var isPasswordValid = await _userManager.CheckPasswordAsync(user, model.Password);
            if (!isPasswordValid)
                return ServiceResponse<SignInResult>.FailureResponse("Invalid email or password.");

            if (!await _userManager.IsEmailConfirmedAsync(user))
            {
                try
                {
                    var token = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                    var confirmationLink = $"{origin}/Auth/ConfirmEmail?userId={user.Id}&token={Uri.EscapeDataString(token)}";

                    var placeholders = new Dictionary<string, string>
                    {
                        { "UserName", user.UserName ?? user.Email! },
                        { "ConfirmationLink", confirmationLink }
                    };

                    var emailBody = await _emailService.GetEmailTemplateAsync("ConfirmEmailTemplate", placeholders);
                    await _emailService.SendEmailAsync(user.Email!, "Confirm Your Email - Mazeed+", emailBody);
                }
                catch (Exception ex)
                {}

                return ServiceResponse<SignInResult>.SuccessResponse(
                    SignInResult.NotAllowed,
                    "Email is not confirmed. A new confirmation link has been sent."
                );
            }

            var result = await _signInManager.PasswordSignInAsync(user, model.Password, model.RememberMe, lockoutOnFailure: true);
            if (!result.Succeeded)
                return ServiceResponse<SignInResult>.FailureResponse("Invalid email or password.");

            return ServiceResponse<SignInResult>.SuccessResponse(result, "Logged in successfully.");
        }

        public async Task<ServiceResponse<bool>> LogoutAsync()
        {
            await _signInManager.SignOutAsync();
            return ServiceResponse<bool>.SuccessResponse(true, "Logged out successfully.");
        }
        #endregion

        #region Email Confirmation

        public async Task<ServiceResponse<bool>> ConfirmEmailAsync(string userId, string token)
        {
            if (string.IsNullOrEmpty(userId) || string.IsNullOrEmpty(token))
                return ServiceResponse<bool>.FailureResponse("Invalid email confirmation link.");

            var user = await _userManager.FindByIdAsync(userId);
            if (user == null)
                return ServiceResponse<bool>.FailureResponse("User not found.");

            var result = await _userManager.ConfirmEmailAsync(user, token);
            if (!result.Succeeded)
                return ServiceResponse<bool>.FailureResponse("Email confirmation failed.");

            return ServiceResponse<bool>.SuccessResponse(true, "Email confirmed successfully.");
        }
        #endregion

        #region Forgot & Reset Password
        public async Task<ServiceResponse<string>> GeneratePasswordResetTokenAsync(string email)
        {
            var user = await _userManager.FindByEmailAsync(email);
            // Protect against email enumeration
            if (user == null || !await _userManager.IsEmailConfirmedAsync(user))
            {
                return ServiceResponse<string>.SuccessResponse(string.Empty, "If the email is registered, a password reset link has been sent.");
            }

            var token = await _userManager.GeneratePasswordResetTokenAsync(user);
            return ServiceResponse<string>.SuccessResponse(token, "Password reset token generated.");
        }

        public async Task<ServiceResponse<bool>> ResetPasswordAsync(ResetPasswordVM model)
        {
            var user = await _userManager.FindByEmailAsync(model.Email);
            if (user == null)
                return ServiceResponse<bool>.SuccessResponse(true, "Password reset successful.");

            var result = await _userManager.ResetPasswordAsync(user, model.Token, model.Password);
            if (!result.Succeeded)
            {
                var errors = string.Join(", ", result.Errors.Select(e => e.Description));
                return ServiceResponse<bool>.FailureResponse($"Reset failed: {errors}");
            }

            return ServiceResponse<bool>.SuccessResponse(true, "Password reset successfully.");
        }
        #endregion

        #region External Authentication
        public AuthenticationProperties ConfigureExternalAuthenticationProperties(string provider, string redirectUrl)
        {
            return _signInManager.ConfigureExternalAuthenticationProperties(provider, redirectUrl);
        }

        public async Task<ServiceResponse<ExternalLoginInfo>> GetExternalLoginInfoAsync()
        {
            var info = await _signInManager.GetExternalLoginInfoAsync();
            if (info == null)
                return ServiceResponse<ExternalLoginInfo>.FailureResponse("Error loading external login information.");

            return ServiceResponse<ExternalLoginInfo>.SuccessResponse(info);
        }

        public async Task<ServiceResponse<SignInResult>> ExternalLoginSignInAsync(ExternalLoginInfo info)
        {
            var result = await _signInManager.ExternalLoginSignInAsync(info.LoginProvider, info.ProviderKey, isPersistent: false, bypassTwoFactor: true);
            return ServiceResponse<SignInResult>.SuccessResponse(result);
        }

        public async Task<ServiceResponse<bool>> RegisterExternalUserAsync(ExternalLoginInfo info, string userName)
        {
            var email = info.Principal.FindFirstValue(ClaimTypes.Email);
            if (string.IsNullOrEmpty(email))
                return ServiceResponse<bool>.FailureResponse("Email claims not provided by external login.");

            var user = new User { UserName = userName, Email = email, EmailConfirmed = true, CreatedBy = "ExternalLogin" };
            var createResult = await _userManager.CreateAsync(user);

            if (!createResult.Succeeded)
            {
                var errors = string.Join(", ", createResult.Errors.Select(e => e.Description));
                return ServiceResponse<bool>.FailureResponse($"Account creation failed: {errors}");
            }

            await _userManager.AddToRoleAsync(user, "User");

            var addLoginResult = await _userManager.AddLoginAsync(user, info);
            if (!addLoginResult.Succeeded)
            {
                var errors = string.Join(", ", addLoginResult.Errors.Select(e => e.Description));
                return ServiceResponse<bool>.FailureResponse($"Linking external login failed: {errors}");
            }

            await _signInManager.SignInAsync(user, isPersistent: false);
            return ServiceResponse<bool>.SuccessResponse(true, "External login registered successfully.");
        }
        #endregion
    }
}