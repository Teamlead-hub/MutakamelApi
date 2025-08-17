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
    public class V_MaterialRequirementsPlanningDetService : RootService<V_MaterialRequirementsPlanningDet>, IV_MaterialRequirementsPlanningDetService
    {
        public V_MaterialRequirementsPlanningDetService(IRepository<V_MaterialRequirementsPlanningDet> repository) : base(repository)
        {
        }

    }
}
