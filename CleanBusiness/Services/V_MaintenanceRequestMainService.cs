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
    public class V_MaintenanceRequestMainService : RootService<V_MaintenanceRequestMain>, IV_MaintenanceRequestMain
    {
        public V_MaintenanceRequestMainService(IRepository<V_MaintenanceRequestMain> repository) : base(repository)
        {
        }
    }
}
