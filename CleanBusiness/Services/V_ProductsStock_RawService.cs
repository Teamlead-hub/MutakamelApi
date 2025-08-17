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
    public class V_ProductsStock_RawService : RootService<V_ProductsStock_Raw> , IV_ProductsStock_RawService
    {
       public V_ProductsStock_RawService(IRepository<V_ProductsStock_Raw> repository):base(repository) 
        { }
    }
}
