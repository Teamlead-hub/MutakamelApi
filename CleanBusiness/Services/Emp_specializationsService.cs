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
    public class Emp_specializationsService : RootService<Emp_specializations>, IEmp_specializations
    {
        public Emp_specializationsService(IRepository<Emp_specializations> repository) : base(repository)
        {
        }
    }
}
