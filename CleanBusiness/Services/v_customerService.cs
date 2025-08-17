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
    public class v_customerService : RootService<v_customer>, Iv_customer
    {
        public v_customerService(IRepository<v_customer> repository) : base(repository)
        {
        }
    }
}
