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
    public class V_DiscountMainService : RootService<V_DiscountMain>, IV_DiscountMain
    {
        public V_DiscountMainService(IRepository<V_DiscountMain> repository) : base(repository)
        {
        }
    }
}
