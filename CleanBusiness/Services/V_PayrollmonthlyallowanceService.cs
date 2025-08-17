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
    public class V_PayrollmonthlyallowanceService : RootService<V_Payrollmonthlyallowance>, IV_Payrollmonthlyallowance
    {
        public V_PayrollmonthlyallowanceService(IRepository<V_Payrollmonthlyallowance> repository) : base(repository)
        {
        }
    }
}
