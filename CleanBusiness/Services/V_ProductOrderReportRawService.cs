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
    public class V_ProductOrderReportRawService : RootService<V_ProductOrderReportRaw>, IV_ProductOrderReportRaw
    {
        public V_ProductOrderReportRawService(IRepository<V_ProductOrderReportRaw> repository) : base(repository)
        {
        }
    }
}
