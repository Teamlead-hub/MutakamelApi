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
    public class V_EmployeeProductionService:RootService<V_EmployeeProduction>, IV_EmployeeProductionService
    {
        public V_EmployeeProductionService(IRepository<V_EmployeeProduction> repository) : base(repository) { }
    }
}
