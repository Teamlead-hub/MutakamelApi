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
    public class V_LeadDealActivityService : RootService<V_LeadDealActivity>, IV_LeadDealActivityService
    {
        public V_LeadDealActivityService(IRepository<V_LeadDealActivity> repository) : base(repository)
        {
        }

    }
}
