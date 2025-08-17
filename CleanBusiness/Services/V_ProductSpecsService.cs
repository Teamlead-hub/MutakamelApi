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
    public class V_ProductSpecsService : RootService<V_ProductSpecs>, IV_ProductSpecsService
    {
        public V_ProductSpecsService(IRepository<V_ProductSpecs> repository):base(repository) { }
    }
}
