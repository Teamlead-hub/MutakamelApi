using CleanAPI;
using CleanBase.Entities;
using Microsoft.AspNetCore.SignalR;

//public class NotificationHub : Hub
//{
//    public async Task SendMessage(NotificationLog message)
//    {
//        // Broadcast the message to all connected clients
//        await Clients.All.SendAsync("ReceiveMessage", message);
//    }
//}

public class NotificationHub : Hub
{
    private readonly NotificationUserTracker _tracker;

    public NotificationHub(NotificationUserTracker tracker)
    {
        _tracker = tracker;
    }

    public override Task OnConnectedAsync()
    {
        var userId = Context.GetHttpContext()?.Request.Query["userId"].ToString();
        if (!string.IsNullOrEmpty(userId))
            _tracker.AddConnection(userId, Context.ConnectionId);

        return base.OnConnectedAsync();
    }

    public override Task OnDisconnectedAsync(Exception? exception)
    {
        _tracker.RemoveConnection(Context.ConnectionId);
        return base.OnDisconnectedAsync(exception);
    }

    // Optionally, expose a hub method to send a notification
    public async Task SendNotificationToUser(NotificationLog notification)
    {
        var connections = _tracker.GetConnections(notification.ToUsersId!);
        foreach (var connectionId in connections)
        {
            await Clients.Client(connectionId).SendAsync("ReceiveNotification", notification);
        }
    }

}
