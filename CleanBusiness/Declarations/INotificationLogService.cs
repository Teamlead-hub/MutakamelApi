using CleanBase.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBusiness.Declarations
{
    public interface INotificationLogService : IRootService<NotificationLog>
    {
        Task<NotificationLog> AddNotificationAsync(NotificationLog entity); // Interface method to generate token

    }
}
