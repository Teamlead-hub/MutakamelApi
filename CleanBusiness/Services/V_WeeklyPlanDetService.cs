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
    public class V_WeeklyPlanDetService : RootService<V_WeeklyPlanDet>, IV_WeeklyPlanDetService
    {
        public V_WeeklyPlanDetService(IRepository<V_WeeklyPlanDet> repository) : base(repository)
        { }
    }
}
