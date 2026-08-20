using Mazeed.BLL.Services.Abstraction;
using Mazeed.BLL.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Mazeed.Web.Controllers
{
    public class ItemsController : Controller
    {
        private readonly IItemService _itemService;
        private readonly ICategoryService _categoryService;
        private readonly IBrandService _brandService;

        public ItemsController(
            IItemService itemService,
            ICategoryService categoryService,
            IBrandService brandService)
        {
            _itemService = itemService;
            _categoryService = categoryService;
            _brandService = brandService;
        }

        // GET: ITEMS[cite: 23]
        public async Task<IActionResult> Index()
        {
            var response = await _itemService.GetAllAsync();
            return View(response.Data ?? new List<ItemVM>());
        }

        // GET: ITEMS/Details/5[cite: 23]
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var response = await _itemService.GetByIdAsync(id.Value);
            if (!response.Succeeded)
            {
                return NotFound();
            }

            return View(response.Data);
        }

        // GET: ITEMS/Create[cite: 23]
        public async Task<IActionResult> Create()
        {
            await PopulateDropdownsAsync();
            return View();
        }

        // POST: ITEMS/Create[cite: 23]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Price,CategoryId,BrandId")] ItemVM item)
        {
            if (ModelState.IsValid)
            {
                var response = await _itemService.CreateAsync(item);
                if (response.Succeeded)
                {
                    return RedirectToAction(nameof(Index));
                }
                ModelState.AddModelError(string.Empty, response.Message ?? "Failed to create item.");
            }

            await PopulateDropdownsAsync(item.CategoryId, item.BrandId);
            return View(item);
        }

        // GET: ITEMS/Edit/5[cite: 23]
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var response = await _itemService.GetByIdAsync(id.Value);
            if (!response.Succeeded || response.Data == null)
            {
                return NotFound();
            }

            await PopulateDropdownsAsync(response.Data.CategoryId, response.Data.BrandId);
            return View(response.Data);
        }

        // POST: ITEMS/Edit/5[cite: 23]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("Id,Name,Price,CategoryId,BrandId")] ItemVM item)
        {
            if (id != item.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                var response = await _itemService.UpdateAsync(item);
                if (response.Succeeded)
                {
                    return RedirectToAction(nameof(Index));
                }
                ModelState.AddModelError(string.Empty, response.Message ?? "Failed to update item.");
            }

            await PopulateDropdownsAsync(item.CategoryId, item.BrandId);
            return View(item);
        }

        // GET: ITEMS/Delete/5[cite: 23]
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var response = await _itemService.GetByIdAsync(id.Value);
            if (!response.Succeeded)
            {
                return NotFound();
            }

            return View(response.Data);
        }

        // POST: ITEMS/Delete/5[cite: 23]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            await _itemService.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }

        private async Task PopulateDropdownsAsync(long? selectedCategoryId = null, long? selectedBrandId = null)
        {
            var categoriesResponse = await _categoryService.GetAllAsync();
            var brandsResponse = await _brandService.GetAllAsync();

            ViewData["CategoryId"] = new SelectList(categoriesResponse.Data ?? new List<CategoryVM>(), "Id", "Name", selectedCategoryId);
            ViewData["BrandId"] = new SelectList(brandsResponse.Data ?? new List<BrandVM>(), "Id", "Name", selectedBrandId);
        }
    }
}