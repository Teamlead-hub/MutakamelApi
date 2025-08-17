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
    public class V_ZVanSalesMainService : RootService<V_ZVanSalesMain>, IV_ZVanSalesMainService
    {
        public V_ZVanSalesMainService(IRepository<V_ZVanSalesMain> repository) : base(repository)
        { }
    }
}
