using Mazeed.BLL.Responses;
using Mazeed.BLL.ViewModels;

namespace Mazeed.BLL.Services.Abstraction
{
    public interface IReviewService
    {
        Task<ServiceResponse<IEnumerable<ReviewVM>>> GetReviewsByItemIdAsync(long itemId);
        Task<ServiceResponse<ItemRatingSummaryVM>> GetRatingSummaryAsync(long itemId);
        Task<ServiceResponse<ReviewVM>> CreateReviewAsync(long userId, CreateReviewVM model, string createdBy);
        Task<ServiceResponse<ReviewVM>> UpdateReviewAsync(long userId, long itemId, UpdateReviewVM model, string updatedBy);
        Task<ServiceResponse<bool>> DeleteReviewAsync(long userId, long itemId, string deletedBy);
        Task<ServiceResponse<Dictionary<long, ItemRatingSummaryVM>>> GetRatingSummariesAsync(IEnumerable<long> itemIds);
    }
}