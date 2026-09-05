using Mazeed.BLL.Services.Abstraction;
using Mazeed.BLL.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace Mazeed.Web.Controllers
{
    [Authorize(Roles = "Admin")]
    public class BrandController : Controller
    {
        private readonly IBrandService _brandService;
        private readonly IUserService _userService;

        public BrandController(IBrandService brandService, IUserService userService)
        {
            _brandService = brandService;
            _userService = userService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var userEmail = User.FindFirstValue(ClaimTypes.Email) ?? "admin@mazeed.com";
            var userResponse = await _userService.GetUserByEmailAsync(userEmail);
            if (userResponse.Succeeded)
            {
                ViewBag.CurrentUser = userResponse.Data;
            }

            var response = await _brandService.GetAllAsync();
            var brands = response.Data ?? new List<BrandVM>();
            return View(brands);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(BrandVM model)
        {
            if (!ModelState.IsValid)
            {
                TempData["Error"] = "Please provide valid brand details.";
                return RedirectToAction(nameof(Index));
            }

            var response = await _brandService.CreateAsync(model);
            if (response.Succeeded)
                TempData["Success"] = response.Message ?? "Brand created successfully.";
            else
                TempData["Error"] = response.Message ?? "Failed to create brand.";

            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(BrandVM model)
        {
            if (!ModelState.IsValid)
            {
                TempData["Error"] = "Please fill in all required fields correctly.";
                return RedirectToAction(nameof(Index));
            }

            var response = await _brandService.UpdateAsync(model);
            if (response.Succeeded)
                TempData["Success"] = response.Message ?? "Brand updated successfully.";
            else
                TempData["Error"] = response.Message ?? "Failed to update brand.";

            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(long id)
        {
            var response = await _brandService.DeleteAsync(id);
            if (response.Succeeded)
                TempData["Success"] = response.Message ?? "Brand deleted successfully.";
            else
                TempData["Error"] = response.Message ?? "Failed to delete brand.";

            return RedirectToAction(nameof(Index));
        }
    }
}