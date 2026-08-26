using Mazeed.BLL.ViewModels;
using Microsoft.AspNetCore.SignalR;

namespace Mazeed.BLL.Hubs
{
    public class SignalRNotificationPusher : INotificationPusher
    {
        private readonly IHubContext<NotificationHub> _hubContext;

        public SignalRNotificationPusher(IHubContext<NotificationHub> hubContext)
        {
            _hubContext = hubContext;
        }

        public async Task PushToUserAsync(long userId, NotificationVM notification)
        {
            await _hubContext.Clients.User(userId.ToString()).SendAsync("ReceiveNotification", notification);
        }

        public async Task PushToUsersAsync(IEnumerable<long> userIds, NotificationVM notification)
        {
            var ids = userIds.Select(id => id.ToString()).ToList();
            await _hubContext.Clients.Users(ids).SendAsync("ReceiveNotification", notification);
        }
    }
}