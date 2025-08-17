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
    public class V_MasterProductionScheduleService : RootService<V_MasterProductionSchedule>, IV_MasterProductionScheduleService
    {
        public V_MasterProductionScheduleService(IRepository<V_MasterProductionSchedule> repository) : base(repository)
        {
        }

    }
}
