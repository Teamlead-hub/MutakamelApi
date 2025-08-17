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
    public class V_ProductstestService : RootService<V_Productstest>,IV_ProductstestService
    {
        public V_ProductstestService(IRepository<V_Productstest> repository):base(repository) { }
    }
}
