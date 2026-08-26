using Mazeed.BLL.Services.Abstraction;
using Mazeed.BLL.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Mazeed.PL.Controllers
{
    [Authorize]
    [Route("api/notifications")]
    public class NotificationController : ApiBaseController
    {
        private readonly INotificationService _notificationService;

        public NotificationController(INotificationService notificationService)
        {
            _notificationService = notificationService;
        }

        [HttpGet]
        public async Task<IActionResult> GetMy([FromQuery] bool unreadOnly = false)
            => HandleResponse(await _notificationService.GetUserNotificationsAsync(CurrentUserId, unreadOnly));

        [HttpGet("unread-count")]
        public async Task<IActionResult> GetUnreadCount()
            => HandleResponse(await _notificationService.GetUnreadCountAsync(CurrentUserId));

        [HttpPut("{notificationId:long}/read")]
        public async Task<IActionResult> MarkAsRead(long notificationId)
            => HandleResponse(await _notificationService.MarkAsReadAsync(CurrentUserId, notificationId));

        [HttpPut("read-all")]
        public async Task<IActionResult> MarkAllAsRead()
            => HandleResponse(await _notificationService.MarkAllAsReadAsync(CurrentUserId));

        [Authorize(Roles = "Admin")]
        [HttpPost("broadcast-all")]
        public async Task<IActionResult> BroadcastToAll([FromBody] BroadcastVM model)
            => HandleResponse(await _notificationService.BroadcastToAllAsync(model.Title, model.Msg, model.Type, CurrentUserName));
    }
}