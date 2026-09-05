using Mazeed.DAL.Entities;

namespace Mazeed.DAL.Repos.Abstraction
{
    public interface IDiscountRuleRepository : IGenericRepository<DiscountRule>
    {
        Task<DiscountRule?> GetByPromoCodeAsync(string promoCode);
        Task<IEnumerable<DiscountRule>> GetActiveAutoDiscountsAsync(DateTime now);
    }
}
