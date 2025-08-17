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
    public class V_ZVanSalesOrdersService : RootService<V_ZVanSalesOrders>, IV_ZVanSalesOrdersService
    {
        public V_ZVanSalesOrdersService(IRepository<V_ZVanSalesOrders> repository) : base(repository)
        { }
    }
}
