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
    public class V_SalaryIncreaseRequestService : RootService<V_SalaryIncreaseRequest>, IV_SalaryIncreaseRequest
    {
        public V_SalaryIncreaseRequestService(IRepository<V_SalaryIncreaseRequest> repository) : base(repository)
        {
        }
    }
}
