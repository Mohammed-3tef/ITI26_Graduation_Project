using Mazeed.BLL.Services.Abstraction;
using Mazeed.BLL.ViewModels.User;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Security.Claims;

namespace Mazeed.PL.Controllers
{
    public class AuthController : Controller
    {
        private readonly IAuthService _authService;
        private readonly IEmailService _emailService;
        private readonly IGovernorateService _governorateService;

        public AuthController(IAuthService authService, IEmailService emailService, IGovernorateService governorateService)
        {
            _authService = authService;
            _emailService = emailService;
            _governorateService = governorateService;
        }

        [HttpGet]
        public async Task<IActionResult> GetCitiesByGovernorate(long governorateId)
        {
            var cities = await _governorateService.GetCitiesByGovernorateIdAsync(governorateId, "en");
            return Json(cities);
        }

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
                return View("RegisterConfirmation");
            }

            ModelState.AddModelError(string.Empty, result.Message ?? "Registration failed.");
            return View(model);
        }

        // --- EMAIL CONFIRMATION ---

        [HttpGet, AllowAnonymous]
        public async Task<IActionResult> ConfirmEmail(string userId, string token)
        {
            var result = await _authService.ConfirmEmailAsync(userId, token);
            if (result.Succeeded)
            {
                ViewBag.Success = true;
                return View();
            }

            ViewBag.Success = false;
            ViewBag.ErrorMessage = result.Message;
            return View();
        }

        // --- LOGIN ---

        [HttpGet, AllowAnonymous]
        public IActionResult Login() => View();

        [HttpPost, AllowAnonymous, ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginVM model, string? returnUrl = null)
        {
            if (!ModelState.IsValid) return View(model);

            var result = await _authService.LoginAsync(model);
            if (result.Succeeded)
            {
                if (!string.IsNullOrEmpty(returnUrl) && Url.IsLocalUrl(returnUrl))
                    return Redirect(returnUrl);

                return RedirectToAction("Index", "Home");
            }

            ModelState.AddModelError(string.Empty, result.Message ?? "Invalid login attempt.");
            return View(model);
        }

        // --- FORGOT & RESET PASSWORD ---

        [HttpGet, AllowAnonymous]
        public IActionResult ForgotPassword() => View();

        [HttpPost, AllowAnonymous, ValidateAntiForgeryToken]
        public async Task<IActionResult> ForgotPassword(ForgotPasswordVM model)
        {
            if (!ModelState.IsValid) return View(model);

            var result = await _authService.GeneratePasswordResetTokenAsync(model.Email);
            if (!string.IsNullOrEmpty(result.Data))
            {
                var resetLink = Url.Action("ResetPassword", "Auth", new { email = model.Email, token = result.Data }, Request.Scheme);
                await _emailService.SendEmailAsync(model.Email, "Reset Password", $"<p>Reset your password by <a href='{resetLink}'>clicking here</a>.</p>");
            }

            ViewBag.Message = "If your email is registered, a password reset link has been sent.";
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
                return RedirectToAction(nameof(ResetPasswordConfirmation));
            }

            ModelState.AddModelError(string.Empty, result.Message ?? "Password reset failed.");
            return View(model);
        }

        [HttpGet, AllowAnonymous]
        public IActionResult ResetPasswordConfirmation() => View();

        // --- EXTERNAL LOGIN (GOOGLE) ---

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

        // --- LOGOUT ---

        [HttpPost, Authorize, ValidateAntiForgeryToken]
        public async Task<IActionResult> Logout()
        {
            await _authService.LogoutAsync();
            return RedirectToAction(nameof(Login));
        }
    }
}