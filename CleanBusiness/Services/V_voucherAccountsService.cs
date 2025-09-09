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
    public class V_voucherAccountsService : RootService<V_voucherAccounts>, IV_voucherAccounts
    {
        public V_voucherAccountsService(IRepository<V_voucherAccounts> repository) : base(repository)
        {
        }
    }
}
