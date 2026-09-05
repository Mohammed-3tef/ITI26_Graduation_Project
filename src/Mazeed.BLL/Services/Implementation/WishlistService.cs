using Mazeed.BLL.Responses;
using Mazeed.BLL.Services.Abstraction;
using Mazeed.BLL.ViewModels;
using Mazeed.DAL.Entities;
using Mazeed.DAL.Repos.Abstraction;

namespace Mazeed.BLL.Services.Implementation
{
    public class WishlistService : IWishlistService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IWishlistRepository _wishlistRepository;

        public WishlistService(IUnitOfWork unitOfWork, IWishlistRepository wishlistRepository)
        {
            _unitOfWork = unitOfWork;
            _wishlistRepository = wishlistRepository;
        }

        public async Task<ServiceResponse<IEnumerable<WishlistItemVM>>> GetWishlistAsync(long userId)
        {
            var favorites = await _wishlistRepository.GetFavoritesByUserIdAsync(userId);
            var vms = favorites.Select(MapToWishlistItemVM);

            return ServiceResponse<IEnumerable<WishlistItemVM>>.SuccessResponse(vms, "Wishlist retrieved successfully.");
        }

        public async Task<ServiceResponse<WishlistItemVM>> AddToWishlistAsync(long userId, long itemId)
        {
            var item = await _unitOfWork.Repository<Item>().GetByIdAsync(itemId);
            if (item == null || item.IsDeleted)
                return ServiceResponse<WishlistItemVM>.FailureResponse("Item not found.");

            var existing = await _wishlistRepository.GetFavoriteAsync(userId, itemId);
            if (existing != null)
                return ServiceResponse<WishlistItemVM>.FailureResponse("This item is already in your wishlist.");

            var favorite = new ShopperFavorite { UserId = userId, ItemId = itemId };
            await _wishlistRepository.AddAsync(favorite);
            await _unitOfWork.CompleteAsync();

            var reloaded = await _wishlistRepository.GetFavoriteAsync(userId, itemId);
            return ServiceResponse<WishlistItemVM>.SuccessResponse(MapToWishlistItemVM(reloaded!), "Item added to wishlist.");
        }

        public async Task<ServiceResponse<bool>> RemoveFromWishlistAsync(long userId, long itemId)
        {
            var existing = await _wishlistRepository.GetFavoriteAsync(userId, itemId);
            if (existing == null)
                return ServiceResponse<bool>.FailureResponse("This item is not in your wishlist.");

            _wishlistRepository.Delete(existing);
            await _unitOfWork.CompleteAsync();

            return ServiceResponse<bool>.SuccessResponse(true, "Item removed from wishlist.");
        }

        private static WishlistItemVM MapToWishlistItemVM(ShopperFavorite favorite)
        {
            var item = favorite.Item;

            return new WishlistItemVM
            {
                ItemId = item.Id,
                ItemName = item.Name,
                BrandName = item.Brand?.Name,
                Price = item.Price,
                ImageUrl = item.Photos?.FirstOrDefault()?.PhotoUrl,
                InStock = item.Variants != null && item.Variants.Any(v => !v.IsDeleted && v.StockQuantity > 0)
            };
        }
    }
}