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
    public class V_OverTimeDetailsService : RootService<V_OverTimeDetails>, IV_OverTimeDetails
    {
        public V_OverTimeDetailsService(IRepository<V_OverTimeDetails> repository) : base(repository)
        {
        }
    }
}
