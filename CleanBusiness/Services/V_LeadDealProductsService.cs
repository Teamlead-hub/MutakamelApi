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
    public class V_LeadDealProductsService : RootService<V_LeadDealProducts>, IV_LeadDealProductsService
    {
        public V_LeadDealProductsService(IRepository<V_LeadDealProducts> repository) : base(repository)
        {
        }

    }
}
