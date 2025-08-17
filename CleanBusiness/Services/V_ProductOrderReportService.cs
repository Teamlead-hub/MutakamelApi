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
    public class V_ProductOrderReportService : RootService<V_ProductOrderReport>, IV_ProductOrderReport
    {
        public V_ProductOrderReportService(IRepository<V_ProductOrderReport> repository) : base(repository)
        {
        }

    }
}
