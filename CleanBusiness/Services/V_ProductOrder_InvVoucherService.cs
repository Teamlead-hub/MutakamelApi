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
    public class V_ProductOrder_InvVoucherService : RootService<V_ProductOrder_InvVoucher>, IV_ProductOrder_InvVoucherService
    {
        public V_ProductOrder_InvVoucherService(IRepository<V_ProductOrder_InvVoucher> repository) : base(repository)
        {
        }
    }
}
