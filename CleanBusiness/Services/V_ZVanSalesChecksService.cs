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
    public class V_ZVanSalesChecksService : RootService<V_ZVanSalesChecks>, IV_ZVanSalesChecksService
    {
        public V_ZVanSalesChecksService(IRepository<V_ZVanSalesChecks> repository) : base(repository)
        { }
    }
}
