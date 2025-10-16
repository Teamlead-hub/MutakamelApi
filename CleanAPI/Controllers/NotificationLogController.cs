using CleanBase.Entities;
using CleanBusiness.Declarations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using Serilog;
using System.Diagnostics;
using static Dapper.SqlMapper;

namespace CleanAPI.Controllers
{


    public class NotificationLogController : BaseController<NotificationLog>
    {
        private readonly INotificationLogService _service;
        private readonly IHubContext<NotificationHub> _hubContext;
        private readonly NotificationUserTracker _tracker;


        public NotificationLogController(INotificationLogService service, IHubContext<NotificationHub> hubContext, NotificationUserTracker tracker) : base(service)
        {
            _hubContext = hubContext;
            _service = service;
            _tracker = tracker;
        }

     

        [HttpPost("AddNotification")]
        public async Task<IActionResult> AddNotification([FromBody] NotificationLog notificationLog)
        {
            var result = await _service.AddNotificationAsync(notificationLog);

            // Send only to the target user
            if (!string.IsNullOrEmpty(result.ToUsersId))
            {
                var connectionIds = _tracker.GetConnections(result.ToUsersId);
                foreach (var id in connectionIds)
                {
                    await _hubContext.Clients.Client(id).SendAsync("ReceiveNotification", result);
                }

            }

            return Ok(result);
        }

    }

}
