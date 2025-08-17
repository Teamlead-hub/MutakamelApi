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
    public class V_MaintenanceTestMethodsubService : RootService<V_MaintenanceTestMethodsub>, IV_MaintenanceTestMethodsub
    {
        public V_MaintenanceTestMethodsubService(IRepository<V_MaintenanceTestMethodsub> repository) : base(repository)
        {
        }
    }
}
