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
    public class V_QuarantineMainService : RootService<V_QuarantineMain>, IV_QuarantineMain
    {
        public V_QuarantineMainService(IRepository<V_QuarantineMain> repository) : base(repository)
        {
        }

    }
}
