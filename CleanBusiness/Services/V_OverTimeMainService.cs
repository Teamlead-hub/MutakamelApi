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
    public class V_OverTimeMainService : RootService<V_OverTimeMain>, IV_OverTimeMain
    {
        public V_OverTimeMainService(IRepository<V_OverTimeMain> repository) : base(repository)
        {
        }
    }
}
