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
    public class V_ProductsSaleService : RootService<V_ProductsSale>, IV_ProductsSaleService
    {
        public V_ProductsSaleService(IRepository<V_ProductsSale> repository):base(repository) { }
    }
}
