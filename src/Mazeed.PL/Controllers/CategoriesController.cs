using Mazeed.BLL.Services.Abstraction;
using Mazeed.BLL.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace Mazeed.Web.Controllers
{
    [Authorize(Roles = "Admin")]
    public class CategoriesController : Controller
    {
        private readonly ICategoryService _categoryService;
        private readonly IUserService _userService;

        public CategoriesController(ICategoryService categoryService, IUserService userService)
        {
            _categoryService = categoryService;
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

            var response = await _categoryService.GetAllAsync();
            var categories = response.Data ?? new List<CategoryVM>();
            return View(categories);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Description")] CategoryVM model)
        {
            if (!ModelState.IsValid)
            {
                TempData["Error"] = "Please provide valid category details.";
                return RedirectToAction(nameof(Index));
            }

            var response = await _categoryService.CreateAsync(model);
            if (response.Succeeded)
                TempData["Success"] = response.Message ?? "Category created successfully.";
            else
                TempData["Error"] = response.Message ?? "Failed to create category.";

            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit([Bind("Id,Name,Description")] CategoryVM model)
        {
            if (!ModelState.IsValid)
            {
                TempData["Error"] = "Please fill in all required fields correctly.";
                return RedirectToAction(nameof(Index));
            }

            var response = await _categoryService.UpdateAsync(model);
            if (response.Succeeded)
                TempData["Success"] = response.Message ?? "Category updated successfully.";
            else
                TempData["Error"] = response.Message ?? "Failed to update category.";

            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(long id)
        {
            var response = await _categoryService.DeleteAsync(id);
            if (response.Succeeded)
                TempData["Success"] = response.Message ?? "Category deleted successfully.";
            else
                TempData["Error"] = response.Message ?? "Failed to delete category.";

            return RedirectToAction(nameof(Index));
        }
    }
}