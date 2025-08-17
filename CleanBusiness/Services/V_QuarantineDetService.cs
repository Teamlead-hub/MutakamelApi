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
    public class V_QuarantineDetService : RootService<V_QuarantineDet>, IV_QuarantineDet
    {
        public V_QuarantineDetService(IRepository<V_QuarantineDet> repository) : base(repository)
        {
        }

    }
}
