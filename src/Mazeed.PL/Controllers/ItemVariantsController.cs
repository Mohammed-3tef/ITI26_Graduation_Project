using Mazeed.BLL.Services.Abstraction;
using Mazeed.BLL.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Security.Claims;

namespace Mazeed.Web.Controllers
{
    [Authorize(Roles = "Admin")]
    public class ItemVariantsController : Controller
    {
        private readonly IItemVariantService _itemVariantService;
        private readonly IItemService _itemService;
        private readonly IUserService _userService;

        public ItemVariantsController(
            IItemVariantService itemVariantService,
            IItemService itemService,
            IUserService userService)
        {
            _itemVariantService = itemVariantService;
            _itemService = itemService;
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

            await PopulateItemsDropdownAsync();
            var response = await _itemVariantService.GetAllAsync();
            var variants = response.Data ?? new List<ItemVariantVM>();
            return View(variants);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ItemVariantVM model, string? PhotoUrlsText)
        {
            if (!string.IsNullOrWhiteSpace(PhotoUrlsText))
            {
                model.Photos = PhotoUrlsText.Split(new[] { '\n', '\r', ',' }, StringSplitOptions.RemoveEmptyEntries).Select(s => s.Trim()).ToList();
            }
            if (!ModelState.IsValid)
            {
                TempData["Error"] = "Please fill in all required fields correctly.";
                return RedirectToAction(nameof(Index));
            }

            var response = await _itemVariantService.CreateAsync(model);
            if (response.Succeeded)
                TempData["Success"] = response.Message ?? "Item variant created successfully.";
            else
                TempData["Error"] = response.Message ?? "Failed to create item variant.";

            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(ItemVariantVM model, string? PhotoUrlsText)
        {
            if (!string.IsNullOrWhiteSpace(PhotoUrlsText))
            {
                model.Photos = PhotoUrlsText.Split(new[] { '\n', '\r', ',' }, StringSplitOptions.RemoveEmptyEntries).Select(s => s.Trim()).ToList();
            }
            if (!ModelState.IsValid)
            {
                TempData["Error"] = "Please fill in all required fields correctly.";
                return RedirectToAction(nameof(Index));
            }

            var response = await _itemVariantService.UpdateAsync(model);
            if (response.Succeeded)
                TempData["Success"] = response.Message ?? "Item variant updated successfully.";
            else
                TempData["Error"] = response.Message ?? "Failed to update item variant.";

            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(long id)
        {
            var response = await _itemVariantService.DeleteAsync(id);
            if (response.Succeeded)
                TempData["Success"] = response.Message ?? "Item variant deleted successfully.";
            else
                TempData["Error"] = response.Message ?? "Failed to delete item variant.";

            return RedirectToAction(nameof(Index));
        }

        private async Task PopulateItemsDropdownAsync()
        {
            var itemsResponse = await _itemService.GetAllAsync();
            ViewData["ItemId"] = new SelectList(itemsResponse.Data ?? new List<ItemVM>(), "Id", "Name");
        }
    }
}