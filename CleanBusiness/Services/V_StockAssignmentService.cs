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
    public class V_StockAssignmentService : RootService<V_StockAssignment>, IV_StockAssignment
    {
        public V_StockAssignmentService(IRepository<V_StockAssignment> repository) : base(repository)
        {
        }

    }
}
