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
    public class V_MaintenanceRequestDetService : RootService<V_MaintenanceRequestDet>, IV_MaintenanceRequestDet
    {
        public V_MaintenanceRequestDetService(IRepository<V_MaintenanceRequestDet> repository) : base(repository)
        {
        }
    }
}
