using Mazeed.DAL.Database;
using Mazeed.DAL.Entities;
using Mazeed.DAL.Repos.Abstraction;
using Microsoft.EntityFrameworkCore;

namespace Mazeed.DAL.Repos.Implementation
{
    public class CartRepository : GenericRepository<ShopperCart>, ICartRepository
    {
        private readonly AppDbContext _context;

        public CartRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }

        // Tracked (no AsNoTracking) — callers typically update Quantity or delete this entity right after.
        public async Task<ShopperCart?> GetCartItemAsync(long userId, long itemVariantId)
        {
            return await _context.Set<ShopperCart>()
                .Include(sc => sc.ItemVariant)
                    .ThenInclude(iv => iv.Item)
                        .ThenInclude(i => i.Brand)
                .Include(sc => sc.ItemVariant)
                    .ThenInclude(iv => iv.Item)
                        .ThenInclude(i => i.Photos)
                .FirstOrDefaultAsync(sc => sc.UserId == userId && sc.ItemVariantId == itemVariantId);
        }

        public async Task<IEnumerable<ShopperCart>> GetCartByUserIdAsync(long userId)
        {
            return await _context.Set<ShopperCart>()
                .Include(sc => sc.ItemVariant)
                    .ThenInclude(iv => iv.Item)
                        .ThenInclude(i => i.Brand)
                .Include(sc => sc.ItemVariant)
                    .ThenInclude(iv => iv.Item)
                        .ThenInclude(i => i.Photos)
                .AsNoTracking()
                .Where(sc => sc.UserId == userId)
                .ToListAsync();
        }
    }
}