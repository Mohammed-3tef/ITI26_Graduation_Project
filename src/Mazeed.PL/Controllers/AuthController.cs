using Mazeed.BLL.Services.Abstraction;
using Mazeed.BLL.ViewModels.User;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Security.Claims;

namespace Mazeed.PL.Controllers
{
    public class AuthController : Controller
    {
        private readonly IAuthService _authService;
        private readonly IEmailService _emailService;
        private readonly IGovernorateService _governorateService;
        private readonly IUserService _userService;

        public AuthController(IAuthService authService, IEmailService emailService, IGovernorateService governorateService, IUserService userService)
        {
            _authService = authService;
            _emailService = emailService;
            _governorateService = governorateService;
            _userService = userService;
        }

        [HttpGet]
        public async Task<IActionResult> GetCitiesByGovernorate(long governorateId)
        {
            var cities = await _governorateService.GetCitiesByGovernorateIdAsync(governorateId, "en");
            return Json(cities);
        }

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            base.OnActionExecuting(context);

            // If the user is authenticated, redirect them to the Home page for any action except Logout and GetCitiesByGovernorate
            if (User.Identity?.IsAuthenticated == true)
            {
                var actionName = context.RouteData.Values["action"]?.ToString();

                // Exclude Logout and GetCitiesByGovernorate actions from redirection
                if (!string.Equals(actionName, nameof(Logout), StringComparison.OrdinalIgnoreCase) &&
                    !string.Equals(actionName, nameof(GetCitiesByGovernorate), StringComparison.OrdinalIgnoreCase) &&
                    !string.Equals(actionName, nameof(Profile), StringComparison.OrdinalIgnoreCase))
                {
                    context.Result = RedirectToAction("Index", "Home");
                }
            }
        }

        #region Register
        [HttpGet, AllowAnonymous]
        public async Task<IActionResult> Register()
        {
            var governorates = await _governorateService.GetAllGovernoratesAsync("en");
            ViewBag.Governorates = new SelectList(governorates, "Id", "EnglishName");
            return View();
        }

        [HttpPost, AllowAnonymous, ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterVM model)
        {
            if (!ModelState.IsValid)
            {
                var governorates = await _governorateService.GetAllGovernoratesAsync("en");
                ViewBag.Governorates = new SelectList(governorates, "Id", "EnglishName");
                return View(model);
            }

            var origin = $"{Request.Scheme}://{Request.Host}";
            var result = await _authService.RegisterAsync(model, origin);
            if (result.Succeeded)
            {
                ViewBag.Message = result.Message;
                TempData["Success"] = result.Message;
                return View("RegisterConfirmation");
            }

            ModelState.AddModelError(string.Empty, result.Message ?? "Registration failed.");
            return View(model);
        }
        #endregion

        #region Email Confirmation
        [HttpGet, AllowAnonymous]
        public async Task<IActionResult> ConfirmEmail(string userId, string token)
        {
            var result = await _authService.ConfirmEmailAsync(userId, token);
            if (result.Succeeded)
            {
                ViewBag.Success = true;
                TempData["Success"] = result.Message;
                return View();
            }

            ViewBag.Success = false;
            ViewBag.ErrorMessage = result.Message;
            return View();
        }
        #endregion

        #region Login
        [HttpGet, AllowAnonymous]
        public IActionResult Login() => View();

        [HttpPost, AllowAnonymous, ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginVM model, string? returnUrl = null)
        {
            if (!ModelState.IsValid) return View(model);

            var origin = $"{Request.Scheme}://{Request.Host}";
            var result = await _authService.LoginAsync(model, origin);

            if (result.Data != null && result.Data.IsNotAllowed)
            {
                ViewBag.Message = "Your account is not activated yet. A new confirmation link has been sent to your email.";
                TempData["Info"] = "Your account is not activated yet. A new confirmation link has been sent to your email.";
                return View("RegisterConfirmation");
            }

            if (result.Succeeded && result.Data != null && result.Data.Succeeded)
            {
                if (!string.IsNullOrEmpty(returnUrl) && Url.IsLocalUrl(returnUrl))
                    return Redirect(returnUrl);

                return RedirectToAction("Index", "Home");
            }

            ModelState.AddModelError(string.Empty, result.Message ?? "Invalid login attempt.");
            return View(model);
        }
        #endregion

        #region Forgot & Reset Password
        [HttpGet, AllowAnonymous]
        public IActionResult ForgotPassword() => View();

        [HttpPost, AllowAnonymous, ValidateAntiForgeryToken]
        public async Task<IActionResult> ForgotPassword(ForgotPasswordVM model)
        {
            if (!ModelState.IsValid) return View(model);

            if (await _userService.GetUserByEmailAsync(model.Email) == null)
            {
                TempData["Error"] = "No user found with the provided email address.";
                return View(model);
            }

            var result = await _authService.GeneratePasswordResetTokenAsync(model.Email);
            if (!string.IsNullOrEmpty(result.Data))
            {
                var resetLink = Url.Action("ResetPassword", "Auth", new { email = model.Email, token = result.Data }, Request.Scheme);

                var placeholders = new Dictionary<string, string>
                {
                    { "UserName", (await _userService.GetUserByEmailAsync(model.Email))?.UserName ?? model.Email.Split('@')[0] },
                    { "ResetLink", resetLink! }
                };

                var emailBody = await _emailService.GetEmailTemplateAsync("ResetPasswordTemplate", placeholders);
                await _emailService.SendEmailAsync(model.Email, "Reset Password - Mazeed", emailBody);
            }

            TempData["Success"] = "The password reset link has been sent.";
            return View("ForgotPasswordConfirmation");
        }

        [HttpGet, AllowAnonymous]
        public IActionResult ResetPassword(string email, string token)
        {
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(token))
                return RedirectToAction("Login");

            return View(new ResetPasswordVM { Email = email, Token = token });
        }

        [HttpPost, AllowAnonymous, ValidateAntiForgeryToken]
        public async Task<IActionResult> ResetPassword(ResetPasswordVM model)
        {
            if (!ModelState.IsValid) return View(model);

            var result = await _authService.ResetPasswordAsync(model);
            if (result.Succeeded)
            {
                TempData["Success"] = "Your password has been reset successfully.";
                return RedirectToAction(nameof(ResetPasswordConfirmation));
            }

            ModelState.AddModelError(string.Empty, result.Message ?? "Password reset failed.");
            return View(model);
        }

        [HttpGet, AllowAnonymous]
        public IActionResult ResetPasswordConfirmation() => View();
        #endregion

        #region External Login (Google)
        [HttpPost, AllowAnonymous, ValidateAntiForgeryToken]
        public IActionResult ExternalLogin(string provider, string? returnUrl = null)
        {
            var redirectUrl = Url.Action(nameof(ExternalLoginCallback), "Auth", new { returnUrl });
            var properties = _authService.ConfigureExternalAuthenticationProperties(provider, redirectUrl!);
            return Challenge(properties, provider);
        }

        [HttpGet, AllowAnonymous]
        public async Task<IActionResult> ExternalLoginCallback(string? returnUrl = null, string? remoteError = null)
        {
            if (remoteError != null)
            {
                ModelState.AddModelError(string.Empty, $"Error from external provider: {remoteError}");
                return View(nameof(Login));
            }

            var infoResult = await _authService.GetExternalLoginInfoAsync();
            if (!infoResult.Succeeded || infoResult.Data == null)
            {
                return RedirectToAction(nameof(Login));
            }

            // Attempt login if external credentials are link-matched
            var signInResult = await _authService.ExternalLoginSignInAsync(infoResult.Data);
            if (signInResult.Data != null && signInResult.Data.Succeeded)
            {
                if (!string.IsNullOrEmpty(returnUrl) && Url.IsLocalUrl(returnUrl))
                    return Redirect(returnUrl);

                return RedirectToAction("Index", "Home");
            }

            // First time logging in with external provider - prompt user for a username
            var email = infoResult.Data.Principal.FindFirstValue(ClaimTypes.Email);
            return View("ExternalLoginConfirmation", new ExternalLoginConfirmationVM { Email = email ?? string.Empty });
        }

        [HttpPost, AllowAnonymous, ValidateAntiForgeryToken]
        public async Task<IActionResult> ExternalLoginConfirmation(ExternalLoginConfirmationVM model, string? returnUrl = null)
        {
            if (!ModelState.IsValid) return View(model);

            var infoResult = await _authService.GetExternalLoginInfoAsync();
            if (!infoResult.Succeeded || infoResult.Data == null)
            {
                ModelState.AddModelError(string.Empty, "External login information expired.");
                return View(model);
            }

            var result = await _authService.RegisterExternalUserAsync(infoResult.Data, model.UserName);
            if (result.Succeeded)
            {
                if (!string.IsNullOrEmpty(returnUrl) && Url.IsLocalUrl(returnUrl))
                    return Redirect(returnUrl);

                return RedirectToAction("Index", "Home");
            }

            ModelState.AddModelError(string.Empty, result.Message ?? "External registration failed.");
            return View(model);
        }
        #endregion

        #region User Profile
        [HttpGet, Authorize]
        public async Task<IActionResult> Profile()
        {
            var username = User.FindFirstValue(ClaimTypes.Name);
            if (string.IsNullOrEmpty(username)) return RedirectToAction(nameof(Login));

            var userModel = await _userService.GetUserByNameAsync(username);
            if (userModel == null) return NotFound();

            var governorates = await _governorateService.GetAllGovernoratesAsync("en");

            // تمرير userModel.Governorate لتحديد المحافظة المختارة
            ViewBag.Governorates = new SelectList(governorates, "Id", "EnglishName", userModel.Governorate);

            return View(userModel);
        }

        [HttpPost, Authorize, ValidateAntiForgeryToken]
        public async Task<IActionResult> Profile(UserVM model)
        {
            var username = User.FindFirstValue(ClaimTypes.Name);
            if (string.IsNullOrEmpty(username)) return RedirectToAction(nameof(Login));

            model.UserName = username;

            if (!ModelState.IsValid)
            {
                var governorates = await _governorateService.GetAllGovernoratesAsync("en");
                ViewBag.Governorates = new SelectList(governorates, "Id", "EnglishName", model.Governorate);

                TempData["Error"] = "Please correct the errors in the form.";
                return View(model);
            }

            var updated = await _userService.UpdateUserProfileAsync(model);
            if (updated)
            {
                TempData["Success"] = "Your profile has been updated successfully.";
                return RedirectToAction(nameof(Profile));
            }

            var allGovernorates = await _governorateService.GetAllGovernoratesAsync("en");
            ViewBag.Governorates = new SelectList(allGovernorates, "Id", "EnglishName", model.Governorate);

            TempData["Error"] = "Failed to update profile details.";
            return View(model);
        }
        #endregion

        #region Logout
        [HttpPost, Authorize, ValidateAntiForgeryToken]
        public async Task<IActionResult> Logout()
        {
            await _authService.LogoutAsync();
            return RedirectToAction(nameof(Login));
        }
        #endregion
    }
}