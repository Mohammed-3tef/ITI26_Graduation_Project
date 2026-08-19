using Mazeed.BLL.Services.Abstraction;
using Mazeed.BLL.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Mazeed.Web.Controllers
{
    public class BrandController : Controller
    {
        private readonly IBrandService _brandService;

        public BrandController(IBrandService brandService)
        {
            _brandService = brandService;
        }

        // GET: Brand
        public async Task<IActionResult> Index()
        {
            var response = await _brandService.GetAllAsync();
            return View(response.Data ?? new List<BrandVM>());
        }

        // GET: Brand/Details/5
        public async Task<IActionResult> Details(long id)
        {
            var response = await _brandService.GetByIdAsync(id);
            if (!response.Succeeded)
            {
                return NotFound();
            }

            return View(response.Data);
        }

        // GET: Brand/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Brand/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(BrandVM model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var response = await _brandService.CreateAsync(model);
            if (response.Succeeded)
            {
                TempData["SuccessMessage"] = response.Message;
                return RedirectToAction(nameof(Index));
            }

            ModelState.AddModelError(string.Empty, response.Message ?? "Error occurred.");
            return View(model);
        }

        // GET: Brand/Edit/5
        public async Task<IActionResult> Edit(long id)
        {
            var response = await _brandService.GetByIdAsync(id);
            if (!response.Succeeded)
            {
                return NotFound();
            }

            return View(response.Data);
        }

        // POST: Brand/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, BrandVM model)
        {
            if (id != model.Id)
            {
                return BadRequest();
            }

            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var response = await _brandService.UpdateAsync(model);
            if (response.Succeeded)
            {
                TempData["SuccessMessage"] = response.Message;
                return RedirectToAction(nameof(Index));
            }

            ModelState.AddModelError(string.Empty, response.Message ?? "Error occurred.");
            return View(model);
        }

        // GET: Brand/Delete/5
        public async Task<IActionResult> Delete(long id)
        {
            var response = await _brandService.GetByIdAsync(id);
            if (!response.Succeeded)
            {
                return NotFound();
            }

            return View(response.Data);
        }

        // POST: Brand/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var response = await _brandService.DeleteAsync(id);
            if (response.Succeeded)
            {
                TempData["SuccessMessage"] = response.Message;
                return RedirectToAction(nameof(Index));
            }

            TempData["ErrorMessage"] = response.Message;
            return RedirectToAction(nameof(Index));
        }
    }
}