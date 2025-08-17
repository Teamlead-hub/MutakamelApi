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
    public class V_HolidayDetailsService : RootService<V_HolidayDetails>, IV_HolidayDetails
    {
        public V_HolidayDetailsService(IRepository<V_HolidayDetails> repository) : base(repository)
        {
        }
    }
}
