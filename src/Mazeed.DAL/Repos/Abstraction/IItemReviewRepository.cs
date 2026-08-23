using Mazeed.DAL.Entities;

namespace Mazeed.DAL.Repos.Abstraction
{
    public interface IItemReviewRepository : IGenericRepository<ItemReview>
    {
        Task<ItemReview?> GetByUserAndItemAsync(long userId, long itemId);
        Task<IEnumerable<ItemReview>> GetReviewsByItemIdAsync(long itemId);
        Task<bool> HasVerifiedPurchaseAsync(long userId, long itemId);
        Task<(int Count, double AverageRating)> GetRatingSummaryAsync(long itemId);
    }
}