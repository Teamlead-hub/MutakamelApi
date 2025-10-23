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
    public class V_CostCenterDistributionService : RootService<V_CostCenterDistribution>, IV_CostCenterDistribution
    {
        public V_CostCenterDistributionService(IRepository<V_CostCenterDistribution> repository) : base(repository)
        {
        }

    }
}
