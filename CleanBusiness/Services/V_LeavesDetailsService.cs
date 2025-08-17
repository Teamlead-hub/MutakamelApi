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
    public class V_LeavesDetailsService : RootService<V_LeavesDetails>, IV_LeavesDetails
    {
        public V_LeavesDetailsService(IRepository<V_LeavesDetails> repository) : base(repository)
        {
        }
    }
}
