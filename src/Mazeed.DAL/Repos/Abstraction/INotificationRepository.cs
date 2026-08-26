using Mazeed.DAL.Entities;

namespace Mazeed.DAL.Repos.Abstraction
{
    public interface INotificationRepository : IGenericRepository<Notification>
    {
        Task<IEnumerable<UserNotification>> GetUserNotificationsAsync(long userId, bool unreadOnly = false);
        Task<int> GetUnreadCountAsync(long userId);
        Task<UserNotification?> GetUserNotificationAsync(long userId, long notificationId);
        Task<IEnumerable<UserNotification>> GetUnreadForUpdateAsync(long userId);
        Task AddUserNotificationsAsync(IEnumerable<UserNotification> userNotifications);
        void UpdateUserNotification(UserNotification userNotification);
    }
}