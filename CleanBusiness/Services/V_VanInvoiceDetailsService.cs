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
    public class V_VanInvoiceDetailsService : RootService<V_VanInvoiceDetails>, IV_VanInvoiceDetailsService
    {
        public V_VanInvoiceDetailsService(IRepository<V_VanInvoiceDetails> repository) : base(repository)
        { }
    }
}
