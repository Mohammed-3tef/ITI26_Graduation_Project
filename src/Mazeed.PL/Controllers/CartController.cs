using Mazeed.BLL.Services.Abstraction;
using Mazeed.BLL.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Mazeed.PL.Controllers
{
    [Authorize]
    [Route("api/cart")]
    public class CartController : ApiBaseController
    {
        private readonly ICartService _cartService;

        public CartController(ICartService cartService)
        {
            _cartService = cartService;
        }

        [HttpGet]
        public async Task<IActionResult> GetCart()
            => HandleResponse(await _cartService.GetCartAsync(CurrentUserId));

        [HttpPost]
        public async Task<IActionResult> AddToCart([FromBody] AddToCartVM model)
            => HandleResponse(await _cartService.AddToCartAsync(CurrentUserId, model));

        [HttpPut("{itemVariantId:long}")]
        public async Task<IActionResult> UpdateQuantity(long itemVariantId, [FromBody] UpdateCartQuantityVM model)
            => HandleResponse(await _cartService.UpdateQuantityAsync(CurrentUserId, itemVariantId, model));

        [HttpDelete("{itemVariantId:long}")]
        public async Task<IActionResult> RemoveFromCart(long itemVariantId)
            => HandleResponse(await _cartService.RemoveFromCartAsync(CurrentUserId, itemVariantId));

        [HttpDelete]
        public async Task<IActionResult> ClearCart()
            => HandleResponse(await _cartService.ClearCartAsync(CurrentUserId));
    }
}