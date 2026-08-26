using Mazeed.BLL.Hubs;
using Mazeed.BLL.Responses;
using Mazeed.BLL.Services.Abstraction;
using Mazeed.BLL.ViewModels;
using Mazeed.DAL.Entities;
using Mazeed.DAL.Repos.Abstraction;

namespace Mazeed.BLL.Services.Implementation
{
    public class NotificationService : INotificationService
    {
        private static readonly string[] ValidTypes = { "OrderStatus", "Alert", "Promotion" };

        private readonly IUnitOfWork _unitOfWork;
        private readonly INotificationRepository _notificationRepository;
        private readonly INotificationPusher _pusher;

        public NotificationService(IUnitOfWork unitOfWork, INotificationRepository notificationRepository, INotificationPusher pusher)
        {
            _unitOfWork = unitOfWork;
            _notificationRepository = notificationRepository;
            _pusher = pusher;
        }

        public async Task<ServiceResponse<IEnumerable<NotificationVM>>> GetUserNotificationsAsync(long userId, bool unreadOnly = false)
        {
            var userNotifications = await _notificationRepository.GetUserNotificationsAsync(userId, unreadOnly);
            var vms = userNotifications.Select(MapToVM);

            return ServiceResponse<IEnumerable<NotificationVM>>.SuccessResponse(vms, "Notifications retrieved successfully.");
        }

        public async Task<ServiceResponse<int>> GetUnreadCountAsync(long userId)
        {
            var count = await _notificationRepository.GetUnreadCountAsync(userId);
            return ServiceResponse<int>.SuccessResponse(count, "Unread count retrieved successfully.");
        }

        public async Task<ServiceResponse<NotificationVM>> SendToUserAsync(long userId, string title, string msg, string type, string createdBy)
        {
            if (!ValidTypes.Contains(type))
                return ServiceResponse<NotificationVM>.FailureResponse("Type must be 'OrderStatus', 'Alert', or 'Promotion'.");

            var notification = new Notification
            {
                Title = title,
                Msg = msg,
                Type = type,
                CreatedBy = createdBy
            };

            var userNotification = new UserNotification
            {
                UserId = userId,
                Notification = notification,
                IsRead = false
            };

            await _notificationRepository.AddUserNotificationsAsync(new[] { userNotification });
            await _unitOfWork.CompleteAsync();

            var vm = MapToVM(notification, isRead: false);
            await _pusher.PushToUserAsync(userId, vm);

            return ServiceResponse<NotificationVM>.SuccessResponse(vm, "Notification sent.");
        }

        public async Task<ServiceResponse<NotificationVM>> BroadcastAsync(IEnumerable<long> userIds, string title, string msg, string type, string createdBy)
        {
            var ids = userIds.Distinct().ToList();
            if (!ids.Any())
                return ServiceResponse<NotificationVM>.FailureResponse("No recipients specified.");

            if (!ValidTypes.Contains(type))
                return ServiceResponse<NotificationVM>.FailureResponse("Type must be 'OrderStatus', 'Alert', or 'Promotion'.");

            var notification = new Notification
            {
                Title = title,
                Msg = msg,
                Type = type,
                CreatedBy = createdBy
            };

            var userNotifications = ids.Select(uid => new UserNotification
            {
                UserId = uid,
                Notification = notification,
                IsRead = false
            });

            await _notificationRepository.AddUserNotificationsAsync(userNotifications);
            await _unitOfWork.CompleteAsync();

            var vm = MapToVM(notification, isRead: false);
            await _pusher.PushToUsersAsync(ids, vm);

            return ServiceResponse<NotificationVM>.SuccessResponse(vm, $"Notification broadcast to {ids.Count} user(s).");
        }

        public async Task<ServiceResponse<NotificationVM>> BroadcastToAllAsync(string title, string msg, string type, string createdBy)
        {
            var users = await _unitOfWork.Repository<User>().FindAsync(u => !u.IsDeleted);
            var userIds = users.Select(u => u.Id).ToList();

            if (!userIds.Any())
                return ServiceResponse<NotificationVM>.FailureResponse("No active users to notify.");

            return await BroadcastAsync(userIds, title, msg, type, createdBy);
        }

        public async Task<ServiceResponse<bool>> MarkAsReadAsync(long userId, long notificationId)
        {
            var userNotification = await _notificationRepository.GetUserNotificationAsync(userId, notificationId);
            if (userNotification == null)
                return ServiceResponse<bool>.FailureResponse("Notification not found.");

            if (userNotification.IsRead)
                return ServiceResponse<bool>.SuccessResponse(true, "Notification already marked as read.");

            userNotification.IsRead = true;
            _notificationRepository.UpdateUserNotification(userNotification);
            await _unitOfWork.CompleteAsync();

            return ServiceResponse<bool>.SuccessResponse(true, "Notification marked as read.");
        }

        public async Task<ServiceResponse<bool>> MarkAllAsReadAsync(long userId)
        {
            var unread = (await _notificationRepository.GetUnreadForUpdateAsync(userId)).ToList();
            if (!unread.Any())
                return ServiceResponse<bool>.SuccessResponse(true, "No unread notifications.");

            foreach (var un in unread)
            {
                un.IsRead = true;
                _notificationRepository.UpdateUserNotification(un);
            }

            await _unitOfWork.CompleteAsync();

            return ServiceResponse<bool>.SuccessResponse(true, $"{unread.Count} notification(s) marked as read.");
        }

        private static NotificationVM MapToVM(UserNotification userNotification)
        {
            return MapToVM(userNotification.Notification, userNotification.IsRead);
        }

        private static NotificationVM MapToVM(Notification notification, bool isRead)
        {
            return new NotificationVM
            {
                Id = notification.Id,
                Title = notification.Title,
                Msg = notification.Msg,
                Type = notification.Type,
                IsRead = isRead,
                CreatedAt = notification.CreatedAt
            };
        }
    }
}