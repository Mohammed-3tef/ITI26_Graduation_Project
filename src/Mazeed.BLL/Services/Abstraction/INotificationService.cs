using Mazeed.BLL.Responses;
using Mazeed.BLL.ViewModels;
namespace Mazeed.BLL.Services.Abstraction
{
    public interface INotificationService
    {
        Task<ServiceResponse<IEnumerable<NotificationVM>>> GetUserNotificationsAsync(long userId, bool unreadOnly = false);
        Task<ServiceResponse<int>> GetUnreadCountAsync(long userId);
        Task<ServiceResponse<NotificationVM>> SendToUserAsync(long userId, string title, string msg, string type, string createdBy);
        Task<ServiceResponse<NotificationVM>> BroadcastAsync(IEnumerable<long> userIds, string title, string msg, string type, string createdBy);
        Task<ServiceResponse<NotificationVM>> BroadcastToAllAsync(string title, string msg, string type, string createdBy);
        Task<ServiceResponse<NotificationVM>> BroadcastToRoleAsync(string role, string title, string msg, string type, string createdBy);
        Task<ServiceResponse<bool>> MarkAsReadAsync(long userId, long notificationId);
        Task<ServiceResponse<bool>> MarkAllAsReadAsync(long userId);
    }
}