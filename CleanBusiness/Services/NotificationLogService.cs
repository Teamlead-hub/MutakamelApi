using CleanBase.Entities;
using CleanBusiness.Declarations;
using CleanOperation.Declarations;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBusiness.Services
{
    public class NotificationLogService : RootService<NotificationLog>, INotificationLogService
    {
        private readonly IRepository<NotificationLog> _repository;

        public NotificationLogService(IRepository<NotificationLog> repository)
            : base(repository)
        {
            _repository = repository; // Assign repository instance
        }

        public async Task<NotificationLog> AddNotificationAsync(NotificationLog log)
        {
            // Save the notification in the database
            await _repository.InsertAsync(log);

            // Send the notification to clients via SignalR
            //await _hubContext.Clients.All.SendAsync("ReceiveNotification", log);

            return log;
        }
    }

}
