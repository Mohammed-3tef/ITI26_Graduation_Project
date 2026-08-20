using Mazeed.BLL.Services.Abstraction;
using Mazeed.BLL.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Mazeed.Web.Controllers
{
    public class ItemVariantsController : Controller
    {
        private readonly IItemVariantService _itemVariantService;
        private readonly IItemService _itemService;

        public ItemVariantsController(
            IItemVariantService itemVariantService,
            IItemService itemService)
        {
            _itemVariantService = itemVariantService;
            _itemService = itemService;
        }

        // GET: ItemVariants
        public async Task<IActionResult> Index()
        {
            var response = await _itemVariantService.GetAllAsync();
            return View(response.Data ?? new List<ItemVariantVM>());
        }

        // GET: ItemVariants/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null) return NotFound();

            var response = await _itemVariantService.GetByIdAsync(id.Value);
            if (!response.Succeeded) return NotFound();

            return View(response.Data);
        }

        // GET: ItemVariants/Create
        public async Task<IActionResult> Create()
        {
            await PopulateItemsDropdownAsync();
            return View();
        }

        // POST: ItemVariants/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,SKU,Color,Size,PriceAdjustment,StockQuantity,LowStockThreshold,ItemId")] ItemVariantVM itemVariant)
        {
            if (ModelState.IsValid)
            {
                var response = await _itemVariantService.CreateAsync(itemVariant);
                if (response.Succeeded)
                {
                    return RedirectToAction(nameof(Index));
                }
                ModelState.AddModelError(string.Empty, response.Message ?? "Failed to create item variant.");
            }

            await PopulateItemsDropdownAsync(itemVariant.ItemId);
            return View(itemVariant);
        }

        // GET: ItemVariants/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null) return NotFound();

            var response = await _itemVariantService.GetByIdAsync(id.Value);
            if (!response.Succeeded || response.Data == null) return NotFound();

            await PopulateItemsDropdownAsync(response.Data.ItemId);
            return View(response.Data);
        }

        // POST: ItemVariants/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("Id,SKU,Color,Size,PriceAdjustment,StockQuantity,LowStockThreshold,ItemId")] ItemVariantVM itemVariant)
        {
            if (id != itemVariant.Id) return NotFound();

            if (ModelState.IsValid)
            {
                var response = await _itemVariantService.UpdateAsync(itemVariant);
                if (response.Succeeded)
                {
                    return RedirectToAction(nameof(Index));
                }
                ModelState.AddModelError(string.Empty, response.Message ?? "Failed to update item variant.");
            }

            await PopulateItemsDropdownAsync(itemVariant.ItemId);
            return View(itemVariant);
        }

        // GET: ItemVariants/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null) return NotFound();

            var response = await _itemVariantService.GetByIdAsync(id.Value);
            if (!response.Succeeded) return NotFound();

            return View(response.Data);
        }

        // POST: ItemVariants/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            await _itemVariantService.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }

        private async Task PopulateItemsDropdownAsync(long? selectedItemId = null)
        {
            var itemsResponse = await _itemService.GetAllAsync();
            ViewData["ItemId"] = new SelectList(itemsResponse.Data ?? new List<ItemVM>(), "Id", "Name", selectedItemId);
        }
    }
}