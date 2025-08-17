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
    public class V_ProductOrderReportWagesService : RootService<V_ProductOrderReportWages>, IV_ProductOrderReportWages
    {
        public V_ProductOrderReportWagesService(IRepository<V_ProductOrderReportWages> repository) : base(repository)
        {
        }
    }
}
