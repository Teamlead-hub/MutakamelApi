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
    public class V_EmpAllowanceService : RootService<V_EmpAllowance>, IV_EmpAllowance
    {
        public V_EmpAllowanceService(IRepository<V_EmpAllowance> repository) : base(repository)
        {
        }
    }
}
