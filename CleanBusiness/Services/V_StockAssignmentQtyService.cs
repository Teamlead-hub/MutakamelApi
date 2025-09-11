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
    public class V_StockAssignmentQtyService : RootService<V_StockAssignmentQty>, IV_StockAssignmentQty
    {
        public V_StockAssignmentQtyService(IRepository<V_StockAssignmentQty> repository) : base(repository)
        {
        }

    }
}
