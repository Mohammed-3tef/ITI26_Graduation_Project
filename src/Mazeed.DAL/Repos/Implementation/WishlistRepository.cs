using Mazeed.DAL.Database;
using Mazeed.DAL.Entities;
using Mazeed.DAL.Repos.Abstraction;
using Microsoft.EntityFrameworkCore;

namespace Mazeed.DAL.Repos.Implementation
{
    public class WishlistRepository : GenericRepository<ShopperFavorite>, IWishlistRepository
    {
        private readonly AppDbContext _context;

        public WishlistRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<ShopperFavorite?> GetFavoriteAsync(long userId, long itemId)
        {
            return await _context.Set<ShopperFavorite>()
                .Include(sf => sf.Item).ThenInclude(i => i.Brand)
                .Include(sf => sf.Item).ThenInclude(i => i.Photos)
                .Include(sf => sf.Item).ThenInclude(i => i.Variants)
                .FirstOrDefaultAsync(sf => sf.UserId == userId && sf.ItemId == itemId);
        }

        public async Task<IEnumerable<ShopperFavorite>> GetFavoritesByUserIdAsync(long userId)
        {
            return await _context.Set<ShopperFavorite>()
                .Include(sf => sf.Item).ThenInclude(i => i.Brand)
                .Include(sf => sf.Item).ThenInclude(i => i.Photos)
                .Include(sf => sf.Item).ThenInclude(i => i.Variants)
                .AsNoTracking()
                .Where(sf => sf.UserId == userId)
                .ToListAsync();
        }
    }
}