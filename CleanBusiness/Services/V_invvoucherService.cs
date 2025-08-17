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
    public class V_invvoucherService : RootService<V_invvoucher>, IV_invvoucher
    {
        public V_invvoucherService(IRepository<V_invvoucher> repository) : base(repository)
        { }
    }
}
