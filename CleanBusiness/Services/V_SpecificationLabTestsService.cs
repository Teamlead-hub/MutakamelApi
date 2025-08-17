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
    public class V_SpecificationLabTestsService : RootService<V_SpecificationLabTests>, IV_SpecificationLabTestsService
    {
        public V_SpecificationLabTestsService(IRepository<V_SpecificationLabTests> repository) : base(repository)
        {
        }

    }
}
