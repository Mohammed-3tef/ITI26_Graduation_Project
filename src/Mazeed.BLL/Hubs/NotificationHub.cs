using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.SignalR;

namespace Mazeed.BLL.Hubs
{
    [Authorize]
    public class NotificationHub : Hub
    {
        // No server-invokable methods needed yet — this is push-only (server -> client).
        // Client listens for the "ReceiveNotification" event.
    }
}