using Mazeed.DAL.Entities;

namespace Mazeed.DAL.Repos.Abstraction
{
    public interface IWishlistRepository : IGenericRepository<ShopperFavorite>
    {
        Task<ShopperFavorite?> GetFavoriteAsync(long userId, long itemId);
        Task<IEnumerable<ShopperFavorite>> GetFavoritesByUserIdAsync(long userId);
    }
}