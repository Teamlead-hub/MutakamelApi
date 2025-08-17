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
    public class HrSectionsService : RootService<HrSections>, IHrSections
    {
        public HrSectionsService(IRepository<HrSections> repository) : base(repository)
        {
        }
    }
}
