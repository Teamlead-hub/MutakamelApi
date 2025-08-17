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
    public class V_ProductOrderService : RootService<V_ProductOrder>, IV_ProductOrderService
    {
        public V_ProductOrderService(IRepository<V_ProductOrder> repository) :base(repository)
        { }
    }
}
