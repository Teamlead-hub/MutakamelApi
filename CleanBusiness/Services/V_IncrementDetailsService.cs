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
    public class V_IncrementDetailsService : RootService<V_IncrementDetails>, IV_IncrementDetails
    {
        public V_IncrementDetailsService(IRepository<V_IncrementDetails> repository) : base(repository)
        {
        }
    }
}
