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
    public class V_DiscountDetailsService : RootService<V_DiscountDetails>, IV_DiscountDetails
    {
        public V_DiscountDetailsService(IRepository<V_DiscountDetails> repository) : base(repository)
        {
        }
    }
}
