using Mazeed.BLL.Services.Abstraction;
using Mazeed.BLL.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Mazeed.PL.Controllers
{
    [Route("api/reviews")]
    public class ReviewController : ApiBaseController
    {
        private readonly IReviewService _reviewService;

        public ReviewController(IReviewService reviewService)
        {
            _reviewService = reviewService;
        }

        [AllowAnonymous]
        [HttpGet("item/{itemId:long}")]
        public async Task<IActionResult> GetByItem(long itemId)
            => HandleResponse(await _reviewService.GetReviewsByItemIdAsync(itemId));

        [AllowAnonymous]
        [HttpGet("item/{itemId:long}/summary")]
        public async Task<IActionResult> GetRatingSummary(long itemId)
            => HandleResponse(await _reviewService.GetRatingSummaryAsync(itemId));

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateReviewVM model)
            => HandleResponse(await _reviewService.CreateReviewAsync(CurrentUserId, model, CurrentUserName));

        [AllowAnonymous]
        [HttpPost("summaries")]
        public async Task<IActionResult> GetBatchSummaries([FromBody] BatchSummaryRequestVM model)
            => HandleResponse(await _reviewService.GetRatingSummariesAsync(model.ItemIds));

        [Authorize]
        [HttpPut("{itemId:long}")]
        public async Task<IActionResult> Update(long itemId, [FromBody] UpdateReviewVM model)
            => HandleResponse(await _reviewService.UpdateReviewAsync(CurrentUserId, itemId, model, CurrentUserName));

        [Authorize]
        [HttpDelete("{itemId:long}")]
        public async Task<IActionResult> Delete(long itemId)
            => HandleResponse(await _reviewService.DeleteReviewAsync(CurrentUserId, itemId, CurrentUserName));
    }
}