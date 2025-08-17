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
    public class V_MaintenanceTestsMainService : RootService<V_MaintenanceTestsMain>, IV_MaintenanceTestsMain
    {
        public V_MaintenanceTestsMainService(IRepository<V_MaintenanceTestsMain> repository) : base(repository)
        {
        }
    }
}
