using Mazeed.BLL.Services.Abstraction;
using Mazeed.BLL.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Mazeed.PL.Controllers
{
    [Route("api/discounts")]
    public class DiscountController : ApiBaseController
    {
        private readonly IDiscountService _discountService;

        public DiscountController(IDiscountService discountService)
        {
            _discountService = discountService;
        }

        [Authorize(Roles = "Admin")]
        [HttpGet]
        public async Task<IActionResult> GetAll()
            => HandleResponse(await _discountService.GetAllDiscountRulesAsync());

        [Authorize(Roles = "Admin")]
        [HttpGet("{id:long}")]
        public async Task<IActionResult> GetById(long id)
            => HandleResponse(await _discountService.GetDiscountRuleByIdAsync(id));

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateDiscountRuleVM model)
            => HandleResponse(await _discountService.CreateDiscountRuleAsync(model, CurrentUserName));

        [Authorize(Roles = "Admin")]
        [HttpPut("{id:long}")]
        public async Task<IActionResult> Update(long id, [FromBody] UpdateDiscountRuleVM model)
            => HandleResponse(await _discountService.UpdateDiscountRuleAsync(id, model, CurrentUserName));

        [Authorize(Roles = "Admin")]
        [HttpDelete("{id:long}")]
        public async Task<IActionResult> Delete(long id)
            => HandleResponse(await _discountService.DeleteDiscountRuleAsync(id, CurrentUserName));

        // Shopper-facing: validate a code (or auto-discount) against the current cart total
        [Authorize]
        [HttpPost("apply")]
        public async Task<IActionResult> Apply([FromBody] ApplyPromoCodeVM model)
            => HandleResponse(await _discountService.ValidateAndApplyAsync(model));
    }
}