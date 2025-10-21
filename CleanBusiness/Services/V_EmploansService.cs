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
    public class V_EmploansService : RootService<V_Emploans>, IV_Emploans
    {
        public V_EmploansService(IRepository<V_Emploans> repository) : base(repository)
        {
        }
    }
}
