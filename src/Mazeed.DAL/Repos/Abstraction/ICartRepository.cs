using Mazeed.DAL.Entities;

namespace Mazeed.DAL.Repos.Abstraction
{
    public interface ICartRepository : IGenericRepository<ShopperCart>
    {
        Task<ShopperCart?> GetCartItemAsync(long userId, long itemVariantId);
        Task<IEnumerable<ShopperCart>> GetCartByUserIdAsync(long userId);
    }
}
