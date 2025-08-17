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
    public class v_Maintenance_employeesService : RootService<v_Maintenance_employees>, Iv_Maintenance_employees
    {
        public v_Maintenance_employeesService(IRepository<v_Maintenance_employees> repository) : base(repository)
        {
        }
    }
}
