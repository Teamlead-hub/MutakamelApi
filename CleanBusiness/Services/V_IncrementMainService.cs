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
    public class V_IncrementMainService : RootService<V_IncrementMain>, IV_IncrementMain
    {
        public V_IncrementMainService(IRepository<V_IncrementMain> repository) : base(repository)
        {
        }
    }
}
