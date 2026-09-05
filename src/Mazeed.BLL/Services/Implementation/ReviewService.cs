using Mazeed.BLL.Responses;
using Mazeed.BLL.Services.Abstraction;
using Mazeed.BLL.ViewModels;
using Mazeed.DAL.Entities;
using Mazeed.DAL.Repos.Abstraction;

namespace Mazeed.BLL.Services.Implementation
{
    public class ReviewService : IReviewService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IItemReviewRepository _reviewRepository;

        public ReviewService(IUnitOfWork unitOfWork, IItemReviewRepository reviewRepository)
        {
            _unitOfWork = unitOfWork;
            _reviewRepository = reviewRepository;
        }

        public async Task<ServiceResponse<IEnumerable<ReviewVM>>> GetReviewsByItemIdAsync(long itemId)
        {
            var reviews = await _reviewRepository.GetReviewsByItemIdAsync(itemId);
            var vms = reviews.Select(MapToVM);

            return ServiceResponse<IEnumerable<ReviewVM>>.SuccessResponse(vms, "Reviews retrieved successfully.");
        }

        public async Task<ServiceResponse<ItemRatingSummaryVM>> GetRatingSummaryAsync(long itemId)
        {
            var (count, average) = await _reviewRepository.GetRatingSummaryAsync(itemId);

            var vm = new ItemRatingSummaryVM
            {
                ItemId = itemId,
                ReviewCount = count,
                AverageRating = average
            };

            return ServiceResponse<ItemRatingSummaryVM>.SuccessResponse(vm, "Rating summary retrieved successfully.");
        }

        public async Task<ServiceResponse<ReviewVM>> CreateReviewAsync(long userId, CreateReviewVM model, string createdBy)
        {
            var item = await _unitOfWork.Repository<Item>().GetByIdAsync(model.ItemId);
            if (item == null || item.IsDeleted)
                return ServiceResponse<ReviewVM>.FailureResponse("Item not found.");

            var existing = await _reviewRepository.GetByUserAndItemAsync(userId, model.ItemId);
            if (existing != null)
                return ServiceResponse<ReviewVM>.FailureResponse("You have already reviewed this item. You can edit your existing review instead.");

            var isVerified = await _reviewRepository.HasVerifiedPurchaseAsync(userId, model.ItemId);
            if (!isVerified)
                return ServiceResponse<ReviewVM>.FailureResponse("Only customers who have received this item can leave a review.");

            var review = new ItemReview
            {
                UserId = userId,
                ItemId = model.ItemId,
                Rate = model.Rate,
                Comment = model.Comment,
                CreatedBy = createdBy
            };

            await _reviewRepository.AddAsync(review);
            await _unitOfWork.CompleteAsync();

            var reloaded = await _reviewRepository.GetByUserAndItemAsync(userId, model.ItemId);
            return ServiceResponse<ReviewVM>.SuccessResponse(MapToVM(reloaded!), "Review submitted successfully.");
        }

        public async Task<ServiceResponse<ReviewVM>> UpdateReviewAsync(long userId, long itemId, UpdateReviewVM model, string updatedBy)
        {
            var review = await _reviewRepository.GetByUserAndItemAsync(userId, itemId);
            if (review == null)
                return ServiceResponse<ReviewVM>.FailureResponse("Review not found.");

            review.Rate = model.Rate;
            review.Comment = model.Comment;
            review.UpdatedBy = updatedBy;
            review.UpdatedAt = DateTime.UtcNow;

            _reviewRepository.Update(review);
            await _unitOfWork.CompleteAsync();

            return ServiceResponse<ReviewVM>.SuccessResponse(MapToVM(review), "Review updated successfully.");
        }

        public async Task<ServiceResponse<bool>> DeleteReviewAsync(long userId, long itemId, string deletedBy)
        {
            var review = await _reviewRepository.GetByUserAndItemAsync(userId, itemId);
            if (review == null)
                return ServiceResponse<bool>.FailureResponse("Review not found.");

            review.IsDeleted = true;
            review.DeletedBy = deletedBy;
            review.DeletedAt = DateTime.UtcNow;

            _reviewRepository.Update(review);
            await _unitOfWork.CompleteAsync();

            return ServiceResponse<bool>.SuccessResponse(true, "Review deleted successfully.");
        }

        private static ReviewVM MapToVM(ItemReview review)
        {
            return new ReviewVM
            {
                Id = review.Id,
                ItemId = review.ItemId,
                UserId = review.UserId,
                ReviewerName = review.Shopper != null
                    ? $"{review.Shopper.FirstName} {review.Shopper.LastName}"
                    : "Anonymous",
                Rate = review.Rate,
                Comment = review.Comment,
                CreatedAt = review.CreatedAt
            };
        }

        public async Task<ServiceResponse<Dictionary<long, ItemRatingSummaryVM>>> GetRatingSummariesAsync(IEnumerable<long> itemIds)
        {
            var ids = itemIds.Distinct().ToList();
            var summaries = await _reviewRepository.GetRatingSummariesAsync(ids);

            var result = ids.ToDictionary(id => id, id => new ItemRatingSummaryVM
            {
                ItemId = id,
                ReviewCount = summaries.TryGetValue(id, out var s) ? s.Count : 0,
                AverageRating = summaries.TryGetValue(id, out var s2) ? s2.AverageRating : 0
            });

            return ServiceResponse<Dictionary<long, ItemRatingSummaryVM>>.SuccessResponse(result, "Rating summaries retrieved successfully.");
        }
    }
}