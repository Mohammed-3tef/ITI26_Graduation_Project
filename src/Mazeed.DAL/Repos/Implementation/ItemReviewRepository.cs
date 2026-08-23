using Mazeed.DAL.Database;
using Mazeed.DAL.Entities;
using Mazeed.DAL.Repos.Abstraction;
using Microsoft.EntityFrameworkCore;

namespace Mazeed.DAL.Repos.Implementation
{
    public class ItemReviewRepository : GenericRepository<ItemReview>, IItemReviewRepository
    {
        private readonly AppDbContext _context;

        public ItemReviewRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }

        // Tracked — used right before Update/Delete.
        public async Task<ItemReview?> GetByUserAndItemAsync(long userId, long itemId)
        {
            return await _context.Set<ItemReview>()
                .Include(r => r.Shopper)
                .FirstOrDefaultAsync(r => r.UserId == userId && r.ItemId == itemId && !r.IsDeleted);
        }

        public async Task<IEnumerable<ItemReview>> GetReviewsByItemIdAsync(long itemId)
        {
            return await _context.Set<ItemReview>()
                .Include(r => r.Shopper)
                .AsNoTracking()
                .Where(r => r.ItemId == itemId && !r.IsDeleted)
                .OrderByDescending(r => r.CreatedAt)
                .ToListAsync();
        }

        public async Task<bool> HasVerifiedPurchaseAsync(long userId, long itemId)
        {
            return await _context.Set<OrderDetail>()
                .AnyAsync(od => od.ItemVariant.ItemId == itemId
                    && od.Order.UserId == userId
                    && od.Order.Status == "Delivered");
        }

        public async Task<(int Count, double AverageRating)> GetRatingSummaryAsync(long itemId)
        {
            var ratings = await _context.Set<ItemReview>()
                .AsNoTracking()
                .Where(r => r.ItemId == itemId && !r.IsDeleted)
                .Select(r => r.Rate)
                .ToListAsync();

            if (!ratings.Any())
                return (0, 0);

            return (ratings.Count, Math.Round(ratings.Average(), 2));
        }
    }
}