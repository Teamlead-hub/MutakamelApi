using CleanBase.Entities;
using Microsoft.AspNetCore.SignalR;

    public class NotificationHub : Hub
    {
        public async Task SendMessage(NotificationLog message)
        {
            // Broadcast the message to all connected clients
            await Clients.All.SendAsync("ReceiveMessage", message);
        }
    }

