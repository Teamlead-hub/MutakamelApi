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
    public class MaintenanceRequestDetService : RootService<MaintenanceRequestDet>, IMaintenanceRequestDet
    {
        public MaintenanceRequestDetService(IRepository<MaintenanceRequestDet> repository) : base(repository)
        {
        }
    }
}
