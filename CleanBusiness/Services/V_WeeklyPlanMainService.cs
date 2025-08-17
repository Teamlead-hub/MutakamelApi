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
    public class V_WeeklyPlanMainService : RootService<V_WeeklyPlanMain>, IV_WeeklyPlanMainService
    {
        public V_WeeklyPlanMainService(IRepository<V_WeeklyPlanMain> repository) : base(repository)
        { }
    }
}
