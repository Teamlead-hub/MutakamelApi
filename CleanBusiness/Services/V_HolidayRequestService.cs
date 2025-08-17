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
    public class V_HolidayRequestService : RootService<V_HolidayRequest>, IV_HolidayRequest
    {
        public V_HolidayRequestService(IRepository<V_HolidayRequest> repository) : base(repository)
        {
        }
    }
}
