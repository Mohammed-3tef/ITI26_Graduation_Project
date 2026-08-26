using Mazeed.BLL.ViewModels;

namespace Mazeed.BLL.Hubs
{
    public interface INotificationPusher
    {
        Task PushToUserAsync(long userId, NotificationVM notification);
        Task PushToUsersAsync(IEnumerable<long> userIds, NotificationVM notification);
    }
}