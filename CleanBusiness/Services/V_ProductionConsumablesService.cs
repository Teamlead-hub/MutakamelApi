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
    public class V_ProductionConsumablesService : RootService<V_ProductionConsumables>, IV_ProductionConsumablesService
    {
        public V_ProductionConsumablesService(IRepository<V_ProductionConsumables> repository) : base(repository)
        {
        }
    }
}
