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
    public class V_MaintenanceReportsService : RootService<V_MaintenanceReports>, IV_MaintenanceReports
    {
        public V_MaintenanceReportsService(IRepository<V_MaintenanceReports> repository) : base(repository)
        {
        }
    }
}
