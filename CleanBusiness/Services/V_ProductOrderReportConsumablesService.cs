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
    public class V_ProductOrderReportConsumablesService : RootService<V_ProductOrderReportConsumables>, IV_ProductOrderReportConsumablesService
    {
        public V_ProductOrderReportConsumablesService(IRepository<V_ProductOrderReportConsumables> repository) : base(repository)
        {
        }

    }
}
