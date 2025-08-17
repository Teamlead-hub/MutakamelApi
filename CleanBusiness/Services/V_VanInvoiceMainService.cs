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
    public class V_VanInvoiceMainService : RootService<V_VanInvoiceMain>, IV_VanInvoiceMainService
    {
        public V_VanInvoiceMainService(IRepository<V_VanInvoiceMain> repository) : base(repository)
        { }
    }
}
