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
    public class V_CostCenterDistributionDetService : RootService<V_CostCenterDistributionDet>, IV_CostCenterDistributionDet
    {
        public V_CostCenterDistributionDetService(IRepository<V_CostCenterDistributionDet> repository) : base(repository)
        {
        }

    }
}
