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
    public class V_ReceivingInvvoucherService : RootService<V_ReceivingInvvoucher>, IV_ReceivingInvvoucher
    {
        public V_ReceivingInvvoucherService(IRepository<V_ReceivingInvvoucher> repository) : base(repository)
        { }
    }
}
