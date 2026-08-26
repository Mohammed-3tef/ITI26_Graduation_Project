using Mazeed.BLL.Services.Abstraction;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Mazeed.PL.Controllers
{
    [Authorize]
    [Route("api/wishlist")]
    public class WishlistController : ApiBaseController
    {
        private readonly IWishlistService _wishlistService;

        public WishlistController(IWishlistService wishlistService)
        {
            _wishlistService = wishlistService;
        }

        [HttpGet]
        public async Task<IActionResult> GetWishlist()
            => HandleResponse(await _wishlistService.GetWishlistAsync(CurrentUserId));

        [HttpPost("{itemId:long}")]
        public async Task<IActionResult> AddToWishlist(long itemId)
            => HandleResponse(await _wishlistService.AddToWishlistAsync(CurrentUserId, itemId));

        [HttpDelete("{itemId:long}")]
        public async Task<IActionResult> RemoveFromWishlist(long itemId)
            => HandleResponse(await _wishlistService.RemoveFromWishlistAsync(CurrentUserId, itemId));
    }
}