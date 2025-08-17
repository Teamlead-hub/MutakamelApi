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
    public class LabTestsService : RootService<LabTests>, ILabTests
    {
        public LabTestsService(IRepository<LabTests> repository) : base(repository)
        {
        }

    }
}
