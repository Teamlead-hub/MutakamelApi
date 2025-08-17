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
    public class V_MasterProductionScheduleDetService : RootService<V_MasterProductionScheduleDet>, IV_MasterProductionScheduleDetService
    {
        public V_MasterProductionScheduleDetService(IRepository<V_MasterProductionScheduleDet> repository) : base(repository)
        {
        }

    }
}
