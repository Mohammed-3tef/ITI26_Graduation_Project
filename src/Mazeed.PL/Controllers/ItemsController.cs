using Mazeed.BLL.Services.Abstraction;
using Mazeed.BLL.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace Mazeed.PL.Controllers
{
    [Authorize(Roles = "Admin")]
    public class ItemsController : Controller
    {
        private readonly IItemService _itemService;
        private readonly ICategoryService _categoryService;
        private readonly IBrandService _brandService;
        private readonly IUserService _userService;

        public ItemsController(
            IItemService itemService,
            ICategoryService categoryService,
            IBrandService brandService,
            IUserService userService)
        {
            _itemService = itemService;
            _categoryService = categoryService;
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

            await PopulateDropdownsAsync();
            var response = await _itemService.GetAllAsync();
            var items = response.Data ?? new List<ItemVM>();
            return View(items);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ItemVM model)
        {
            if (!ModelState.IsValid)
            {
                TempData["Error"] = "Please provide valid item details.";
                return RedirectToAction(nameof(Index));
            }

            var response = await _itemService.CreateAsync(model);
            if (response.Succeeded)
                TempData["Success"] = response.Message ?? "Item created successfully.";
            else
                TempData["Error"] = response.Message ?? "Failed to create item.";

            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(ItemVM model)
        {
            if (!ModelState.IsValid)
            {
                TempData["Error"] = "Please fill in all required fields correctly.";
                return RedirectToAction(nameof(Index));
            }

            var response = await _itemService.UpdateAsync(model);
            if (response.Succeeded)
                TempData["Success"] = response.Message ?? "Item updated successfully.";
            else
                TempData["Error"] = response.Message ?? "Failed to update item.";

            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(long id)
        {
            var response = await _itemService.DeleteAsync(id);
            if (response.Succeeded)
                TempData["Success"] = response.Message ?? "Item deleted successfully.";
            else
                TempData["Error"] = response.Message ?? "Failed to delete item.";

            return RedirectToAction(nameof(Index));
        }

        private async Task PopulateDropdownsAsync()
        {
            var categoriesResponse = await _categoryService.GetAllAsync();
            var brandsResponse = await _brandService.GetAllAsync();

            ViewData["Categories"] = new MultiSelectList(
                categoriesResponse.Data ?? new List<CategoryVM>(),
                "Id",
                "Name"
            );

            ViewData["BrandId"] = new SelectList(
                brandsResponse.Data ?? new List<BrandVM>(),
                "Id",
                "Name"
            );
        }

    }
}