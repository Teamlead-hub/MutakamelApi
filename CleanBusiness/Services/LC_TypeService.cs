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
    public class LC_TypeService : RootService<LC_Type>, ILC_Type
    {
        public LC_TypeService(IRepository<LC_Type> repository) : base(repository)
        {
        }
    }
}
