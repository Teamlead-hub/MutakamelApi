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
    public class V_NotificationService : RootService<V_Notification>, IV_NotificationService
    {
        public V_NotificationService(IRepository<V_Notification> repository) : base(repository)
        {
        }
    }
}
