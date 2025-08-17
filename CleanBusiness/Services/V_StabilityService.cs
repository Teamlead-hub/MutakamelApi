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

    public class V_StabilityService : RootService<V_Stability>, IV_StabilityService
    {
        public V_StabilityService(IRepository<V_Stability> repository) : base(repository)
        { }

    }
}
