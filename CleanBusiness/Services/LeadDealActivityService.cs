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
    public class LeadDealActivityService : RootService<LeadDealActivity>, ILeadDealActivityService
    {
        public LeadDealActivityService(IRepository<LeadDealActivity> repository) : base(repository)
        {
        }

    }
}
