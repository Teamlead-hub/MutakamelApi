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
    public class V_ZVanSalesPaymentService : RootService<V_ZVanSalesPayment>, IV_ZVanSalesPaymentService
    {
        public V_ZVanSalesPaymentService(IRepository<V_ZVanSalesPayment> repository) : base(repository)
        { }
    }
}
