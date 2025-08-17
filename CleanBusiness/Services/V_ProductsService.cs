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
    public class V_ProductsService:RootService<V_Products>,IV_ProductsService
    {
        public V_ProductsService(IRepository<V_Products> repository):base(repository) { }
    }
}
