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
    public class V_VouchersService :RootService<V_Vouchers>,IV_Vouchers
    {
        public V_VouchersService(IRepository<V_Vouchers> repository) : base(repository)
        { }
    }
}
