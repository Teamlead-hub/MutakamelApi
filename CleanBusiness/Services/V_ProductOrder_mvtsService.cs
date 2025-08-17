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
    public class V_ProductOrder_mvtsService : RootService<V_ProductOrder_mvts>, IV_ProductOrder_mvtsService
    {
        public V_ProductOrder_mvtsService(IRepository<V_ProductOrder_mvts> repository) : base(repository)
        { }
    }
}
