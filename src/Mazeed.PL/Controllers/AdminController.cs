using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using Mazeed.BLL.Services.Abstraction;
using Mazeed.BLL.ViewModels.User;

namespace Mazeed.PL.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        private readonly IUserService _userService;
        private readonly IGovernorateService _governorateService;
        private readonly ILogger<AdminController> _logger;

        public AdminController(
            IUserService userService,
            IGovernorateService governorateService,
            ILogger<AdminController> logger)
        {
            _userService = userService;
            _governorateService = governorateService;
            _logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var userEmail = GetCurrentUserEmail();
            var userResponse = await _userService.GetUserByEmailAsync(userEmail);

            var model = userResponse.Succeeded && userResponse.Data != null
                ? userResponse.Data
                : new UserVM { Email = userEmail };

            await PopulateGovernoratesDropdownAsync(model.Governorate);

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Users()
        {
            var response = await _userService.GetAllUsersAsync();
            var users = response.Succeeded && response.Data != null
                ? response.Data
                : Enumerable.Empty<UserVM>();

            return View(users);
        }

        [HttpGet]
        public async Task<IActionResult> GetCitiesByGovernorate(long governorateId)
        {
            if (governorateId <= 0)
                return BadRequest("Invalid governorate ID.");

            var response = await _governorateService.GetCitiesByGovernorateIdAsync(governorateId);

            if (!response.Succeeded || response.Data == null)
                return Json(Enumerable.Empty<object>());

            var cities = response.Data.Select(c => new
            {
                id = c.Id,
                name = c.EnglishName
            });

            return Json(cities);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditProfile(UserVM model)
        {
            if (!ModelState.IsValid)
            {
                TempData["Error"] = "Please fill in all required fields correctly.";
                await PopulateGovernoratesDropdownAsync(model.Governorate);
                return View(nameof(Index), model);
            }

            var result = await _userService.UpdateUserProfileAsync(model);

            if (result.Succeeded)
            {
                TempData["Success"] = "Profile updated successfully.";
            }
            else
            {
                _logger.LogWarning("Profile update failed for user {Email}: {Message}", model.Email, result.Message);
                TempData["Error"] = result.Message ?? "Failed to update profile.";
            }

            return RedirectToAction(nameof(Index));
        }

        #region Helper Methods
        private string GetCurrentUserEmail()
        {
            return User.FindFirstValue(ClaimTypes.Email) ?? "admin@mazeed.com";
        }

        private async Task PopulateGovernoratesDropdownAsync(string? selectedGovId)
        {
            var response = await _governorateService.GetAllGovernoratesAsync();

            if (!response.Succeeded || response.Data == null)
            {
                ViewBag.Governorates = Enumerable.Empty<SelectListItem>();
                return;
            }

            ViewBag.Governorates = response.Data.Select(g => new SelectListItem
            {
                Value = g.Id.ToString(),
                Text = g.EnglishName ?? g.Id.ToString(),
                Selected = selectedGovId != null && g.Id.ToString() == selectedGovId
            }).ToList();
        }
        #endregion
    }
}