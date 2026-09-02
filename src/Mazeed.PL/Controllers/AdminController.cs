using Mazeed.BLL.Services.Abstraction;
using Mazeed.BLL.Services.Implementation;
using Mazeed.BLL.ViewModels;
using Mazeed.BLL.ViewModels.User;
using Mazeed.BLL.ViewModels.Admin;
using Mazeed.DAL.Database;
using Mazeed.DAL.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using System.Security.Claims;
using Microsoft.EntityFrameworkCore;

namespace Mazeed.PL.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        private readonly IUserService _userService;
        private readonly IRoleService _roleService;
        private readonly IGovernorateService _governorateService;
        private readonly ICategoryService _categoryService; // 🟢 إضافة
        private readonly IBrandService _brandService;       // 🟢 إضافة
        private readonly ILogger<AdminController> _logger;
        private readonly AppDbContext _context;

        public AdminController(
            IUserService userService,
            IRoleService roleService,
            IGovernorateService governorateService,
            ICategoryService categoryService,               // 🟢 حقن
            IBrandService brandService,                  // 🟢 حقن
            ILogger<AdminController> logger,
            AppDbContext context)
        {
            _userService = userService;
            _roleService = roleService;
            _governorateService = governorateService;
            _categoryService = categoryService;          // 🟢 تعيين
            _brandService = brandService;                // 🟢 تعيين
            _logger = logger;
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var userEmail = GetCurrentUserEmail();
            var userResponse = await _userService.GetUserByEmailAsync(userEmail);

            var model = userResponse.Succeeded && userResponse.Data != null
                ? userResponse.Data
                : new UserVM { Email = userEmail };

            ViewBag.CurrentUser = model;

            // 🟢 سحب البيانات للـ Slicers في الـ Dashboard
            var categoriesResponse = await _categoryService.GetAllAsync();
            ViewBag.Categories = categoriesResponse.Succeeded ? categoriesResponse.Data : Enumerable.Empty<CategoryVM>();

            var brandsResponse = await _brandService.GetAllAsync();
            ViewBag.Brands = brandsResponse.Succeeded ? brandsResponse.Data : Enumerable.Empty<BrandVM>();

            return View("~/Views/Dashboard/Index.cshtml", model);
        }

        // Pass Roles and User-Role assignments via ViewBag to Users action
        [HttpGet]
        public async Task<IActionResult> Users()
        {
            var userEmail = GetCurrentUserEmail();
            var currentUserResponse = await _userService.GetUserByEmailAsync(userEmail);
            if (currentUserResponse.Succeeded)
            {
                ViewBag.CurrentUser = currentUserResponse.Data;
            }

            var response = await _userService.GetAllUsersAsync();
            var users = response.Succeeded && response.Data != null
                ? response.Data
                : Enumerable.Empty<UserVM>();

            var rolesResponse = await _roleService.GetAllRolesAsync();
            ViewBag.Roles = rolesResponse.Data ?? Enumerable.Empty<RoleVM>();

            var userRolesResponse = await _roleService.GetUsersWithRolesAsync();
            ViewBag.UserRoles = userRolesResponse.Data ?? Enumerable.Empty<UserRoleVM>();

            await PopulateGovernoratesDropdownAsync(null);

            return View(users);
        }

        [HttpGet]
        public async Task<IActionResult> Sales(string? search, string? status, DateTime? startDate, DateTime? endDate)
        {
            await PopulateCurrentAdminAsync();

            var query = _context.Orders
                .AsNoTracking()
                .Include(order => order.Payment)
                .Include(order => order.OrderDetails)
                    .ThenInclude(detail => detail.ItemVariant)
                        .ThenInclude(variant => variant.Item)
                .Where(order => !order.IsDeleted);

            if (!string.IsNullOrWhiteSpace(search))
            {
                search = search.Trim();
                query = query.Where(order => order.Id.ToString().Contains(search) ||
                    (order.FirstName + " " + order.LastName).Contains(search) ||
                    order.PhoneNumber.Contains(search));
            }

            if (!string.IsNullOrWhiteSpace(status))
                query = query.Where(order => order.Status == status);
            if (startDate.HasValue)
                query = query.Where(order => order.OrderingDate >= startDate.Value.Date);
            if (endDate.HasValue)
                query = query.Where(order => order.OrderingDate < endDate.Value.Date.AddDays(1));

            var orders = await query.OrderByDescending(order => order.OrderingDate).ToListAsync();
            var model = orders.Select(order => new SalesOrderVM
            {
                Id = order.Id,
                OrderingDate = order.OrderingDate,
                CustomerName = $"{order.FirstName} {order.LastName}",
                PhoneNumber = order.PhoneNumber,
                ShippingAddress = order.ShippingAddress,
                TotalPrice = order.TotalPrice,
                Status = order.Status,
                PaymentStatus = order.Payment?.Status ?? "Not recorded",
                ItemsCount = order.OrderDetails.Sum(detail => detail.Quantity),
                Items = order.OrderDetails.Select(detail => new SalesOrderItemVM
                {
                    ItemName = detail.ItemVariant.Item.Name,
                    SKU = detail.ItemVariant.SKU,
                    Variant = $"{detail.ItemVariant.Color} / {detail.ItemVariant.Size}",
                    Quantity = detail.Quantity,
                    PricePerItem = detail.PricePerItem
                }).ToList()
            }).ToList();

            ViewBag.Search = search;
            ViewBag.Status = status;
            ViewBag.StartDate = startDate?.ToString("yyyy-MM-dd");
            ViewBag.EndDate = endDate?.ToString("yyyy-MM-dd");
            ViewBag.Statuses = new[] { "Pending", "Paid", "Processing", "Shipped", "Delivered", "Cancelled", "Payment failed" };
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> UpdateOrderStatus(long id, string status)
        {
            var validStatuses = new[] { "Pending", "Paid", "Processing", "Shipped", "Delivered", "Cancelled", "Payment failed" };
            if (!validStatuses.Contains(status))
            {
                TempData["Error"] = "Invalid order status.";
                return RedirectToAction(nameof(Sales));
            }

            var order = await _context.Orders.FirstOrDefaultAsync(order => order.Id == id && !order.IsDeleted);
            if (order == null)
            {
                TempData["Error"] = "Order not found.";
                return RedirectToAction(nameof(Sales));
            }

            order.Status = status;
            order.UpdatedBy = GetCurrentUserEmail();
            order.UpdatedAt = DateTime.UtcNow;
            await _context.SaveChangesAsync();
            TempData["Success"] = $"Order #{id} status updated.";
            return RedirectToAction(nameof(Sales));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateRole(string roleName)
        {
            if (string.IsNullOrWhiteSpace(roleName))
            {
                TempData["Error"] = "Role name cannot be empty.";
                return RedirectToAction(nameof(Users));
            }

            var result = await _roleService.CreateRoleAsync(roleName.Trim());
            if (result.Succeeded)
                TempData["Success"] = "Role created successfully.";
            else
                TempData["Error"] = result.Message;

            return RedirectToAction(nameof(Users));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteRole(string roleName)
        {
            var result = await _roleService.DeleteRoleAsync(roleName);
            if (result.Succeeded)
                TempData["Success"] = "Role deleted successfully.";
            else
                TempData["Error"] = result.Message;

            return RedirectToAction(nameof(Users));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ManageUserRoles(string email, List<string> roles)
        {
            var result = await _roleService.UpdateUserRolesAsync(email, roles);
            if (result.Succeeded)
                TempData["Success"] = "User roles updated successfully.";
            else
                TempData["Error"] = result.Message;

            return RedirectToAction(nameof(Users));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateUser(UserVM model)
        {
            if (!ModelState.IsValid)
            {
                TempData["Error"] = "Please fill in all required fields.";
                return RedirectToAction(nameof(Users));
            }

            var result = await _userService.CreateUserAsync(model);
            if (result.Succeeded)
                TempData["Success"] = "User created successfully.";
            else
                TempData["Error"] = result.Message ?? "Failed to create user.";

            return RedirectToAction(nameof(Users));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditUser(UserVM model)
        {
            if (!ModelState.IsValid)
            {
                TempData["Error"] = "Please fill in all required fields correctly.";
                return RedirectToAction(nameof(Users));
            }

            var result = await _userService.UpdateUserProfileAsync(model);

            if (result.Succeeded)
                TempData["Success"] = "User updated successfully.";
            else
                TempData["Error"] = result.Message ?? "Failed to update user.";

            return RedirectToAction(nameof(Users));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteUser(string email)
        {
            var result = await _userService.DeleteUserByEmailAsync(email);
            if (result.Succeeded)
                TempData["Success"] = "User deleted successfully.";
            else
                TempData["Error"] = result.Message ?? "Failed to delete user.";

            return RedirectToAction(nameof(Users));
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

        private async Task PopulateCurrentAdminAsync()
        {
            var response = await _userService.GetUserByEmailAsync(GetCurrentUserEmail());
            if (response.Succeeded)
                ViewBag.CurrentUser = response.Data;
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