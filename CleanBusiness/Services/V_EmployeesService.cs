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
    public class V_EmployeesService : RootService<V_Employees>, IV_Employees
    {
        public V_EmployeesService(IRepository<V_Employees> repository) : base(repository)
        {
        }
    }
}
