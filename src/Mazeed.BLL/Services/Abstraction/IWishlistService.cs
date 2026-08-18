using Mazeed.BLL.Responses;
using Mazeed.BLL.ViewModels;

namespace Mazeed.BLL.Services.Abstraction
{
    public interface IWishlistService
    {
        Task<ServiceResponse<IEnumerable<WishlistItemVM>>> GetWishlistAsync(long userId);
        Task<ServiceResponse<WishlistItemVM>> AddToWishlistAsync(long userId, long itemId);
        Task<ServiceResponse<bool>> RemoveFromWishlistAsync(long userId, long itemId);
    }
}