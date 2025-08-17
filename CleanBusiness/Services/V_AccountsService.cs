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
    public class V_AccountsService : RootService<V_Accounts>, IV_Accounts
    {
        public V_AccountsService(IRepository<V_Accounts> repository) : base(repository)
        {
        }
    }
}
