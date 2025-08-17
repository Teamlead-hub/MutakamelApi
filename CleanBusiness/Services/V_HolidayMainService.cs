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
    public class V_HolidayMainService : RootService<V_HolidayMain>, IV_HolidayMain
    {
        public V_HolidayMainService(IRepository<V_HolidayMain> repository) : base(repository)
        {
        }
    }
}
