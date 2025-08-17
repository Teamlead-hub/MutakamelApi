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
    public class V_MaintenanceAssetsMainService : RootService<V_MaintenanceAssetsMain>, IV_MaintenanceAssetsMain
    {
        public V_MaintenanceAssetsMainService(IRepository<V_MaintenanceAssetsMain> repository) : base(repository)
        {
        }
    }
}
