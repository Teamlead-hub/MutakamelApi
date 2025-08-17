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
    public class LeavesDetailsService : RootService<LeavesDetails>, ILeavesDetails
    {
        public LeavesDetailsService(IRepository<LeavesDetails> repository) : base(repository)
        {
        }
    }
}
