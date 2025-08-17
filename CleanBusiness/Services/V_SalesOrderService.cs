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
    public class V_SalesOrderService : RootService<V_SalesOrder>, IV_SalesOrder
    {
        public V_SalesOrderService(IRepository<V_SalesOrder> repository) : base(repository)
        { }
    }
}
