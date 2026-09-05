using Mazeed.DAL.Database;
using Mazeed.DAL.Entities;
using Mazeed.DAL.Repos.Abstraction;
using Microsoft.EntityFrameworkCore;

namespace Mazeed.DAL.Repos.Implementation
{
    public class DiscountRuleRepository : GenericRepository<DiscountRule>, IDiscountRuleRepository
    {
        private readonly AppDbContext _context;

        public DiscountRuleRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<DiscountRule?> GetByPromoCodeAsync(string promoCode)
        {
            var normalized = promoCode.Trim().ToLower();
            return await _context.Set<DiscountRule>()
                .AsNoTracking()
                .FirstOrDefaultAsync(r => !r.IsDeleted
                    && r.PromotionCode != null
                    && r.PromotionCode.ToLower() == normalized);
        }

        public async Task<IEnumerable<DiscountRule>> GetActiveAutoDiscountsAsync(DateTime now)
        {
            return await _context.Set<DiscountRule>()
                .AsNoTracking()
                .Where(r => !r.IsDeleted
                    && r.IsActive
                    && r.PromotionCode == null
                    && r.StartDate <= now
                    && r.EndDate >= now)
                .ToListAsync();
        }
    }
}