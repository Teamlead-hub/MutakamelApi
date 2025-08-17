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
    public class V_MaintenanceAssetsDetService : RootService<V_MaintenanceAssetsDet>, IV_MaintenanceAssetsDet
    {
        public V_MaintenanceAssetsDetService(IRepository<V_MaintenanceAssetsDet> repository) : base(repository)
        {
        }
    }
}
