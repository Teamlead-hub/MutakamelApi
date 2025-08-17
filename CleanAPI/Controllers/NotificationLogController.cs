using CleanBase.Entities;
using CleanBusiness.Declarations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using Serilog;
using static Dapper.SqlMapper;

namespace CleanAPI.Controllers
{


    public class NotificationLogController : BaseController<NotificationLog>
    {
        private readonly INotificationLogService _service;
        private readonly IHubContext<NotificationHub> _hubContext;


        public NotificationLogController(INotificationLogService service, IHubContext<NotificationHub> hubContext) : base(service)
        {
            _hubContext = hubContext;
            _service = service;
        }

        [HttpPost("AddNotification")]
        public async Task<IActionResult> AddNotification([FromBody] NotificationLog notificationLog)
        {

            var result = _service.AddNotificationAsync(notificationLog);
            await _hubContext.Clients.All.SendAsync("ReceiveNotification", result);
            return Ok(result);


        }
    }


}
