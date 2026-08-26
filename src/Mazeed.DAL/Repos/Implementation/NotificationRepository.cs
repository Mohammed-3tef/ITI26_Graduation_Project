using Mazeed.DAL.Database;
using Mazeed.DAL.Entities;
using Mazeed.DAL.Repos.Abstraction;
using Microsoft.EntityFrameworkCore;

namespace Mazeed.DAL.Repos.Implementation
{
    public class NotificationRepository : GenericRepository<Notification>, INotificationRepository
    {
        private readonly AppDbContext _context;

        public NotificationRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<UserNotification>> GetUserNotificationsAsync(long userId, bool unreadOnly = false)
        {
            var query = _context.Set<UserNotification>()
                .Include(un => un.Notification)
                .AsNoTracking()
                .Where(un => un.UserId == userId);

            if (unreadOnly)
                query = query.Where(un => !un.IsRead);

            return await query
                .OrderByDescending(un => un.Notification.CreatedAt)
                .ToListAsync();
        }

        public async Task<int> GetUnreadCountAsync(long userId)
        {
            return await _context.Set<UserNotification>()
                .CountAsync(un => un.UserId == userId && !un.IsRead);
        }

        // Tracked — used right before marking as read.
        public async Task<UserNotification?> GetUserNotificationAsync(long userId, long notificationId)
        {
            return await _context.Set<UserNotification>()
                .Include(un => un.Notification)
                .FirstOrDefaultAsync(un => un.UserId == userId && un.NotificationId == notificationId);
        }

        // Tracked — used for "mark all as read".
        public async Task<IEnumerable<UserNotification>> GetUnreadForUpdateAsync(long userId)
        {
            return await _context.Set<UserNotification>()
                .Where(un => un.UserId == userId && !un.IsRead)
                .ToListAsync();
        }

        public async Task AddUserNotificationsAsync(IEnumerable<UserNotification> userNotifications)
        {
            await _context.Set<UserNotification>().AddRangeAsync(userNotifications);
        }

        public void UpdateUserNotification(UserNotification userNotification)
        {
            _context.Set<UserNotification>().Update(userNotification);
        }
    }
}