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
    public class V_ProductOrderReportPackagingService : RootService<V_ProductOrderReportPackaging>, IV_ProductOrderReportPackagingService
    {
        public V_ProductOrderReportPackagingService(IRepository<V_ProductOrderReportPackaging> repository) : base(repository)
        {
        }
    }
}
