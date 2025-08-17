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
    public class V_MaterialRequirementsPlanningService : RootService<V_MaterialRequirementsPlanning>, IV_MaterialRequirementsPlanningService
    {
        public V_MaterialRequirementsPlanningService(IRepository<V_MaterialRequirementsPlanning> repository) : base(repository)
        {
        }

    }
}
