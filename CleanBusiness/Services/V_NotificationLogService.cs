using CleanBase.Entities;
using CleanBusiness.Declarations;
using CleanOperation.Declarations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBusiness.Services
{
    public class V_NotificationLogService : RootService<V_NotificationLog>, IV_NotificationLogService
    {
        public V_NotificationLogService(IRepository<V_NotificationLog> repository) : base(repository)
        {
        }
    }
}
