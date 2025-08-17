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
    public class V_PinvvoucherService : RootService<V_Pinvvoucher>, IV_PinvvoucherService
    {
        public V_PinvvoucherService(IRepository<V_Pinvvoucher> repository) : base(repository)
        { }
    }
}
