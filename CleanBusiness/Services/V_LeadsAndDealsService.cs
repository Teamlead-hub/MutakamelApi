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
    public class V_LeadsAndDealsService : RootService<V_LeadsAndDeals>, IV_LeadsAndDealsService
    {
        public V_LeadsAndDealsService(IRepository<V_LeadsAndDeals> repository) : base(repository)
        {
        }

    }
}
