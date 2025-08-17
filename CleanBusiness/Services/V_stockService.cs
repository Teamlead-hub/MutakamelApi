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
    public class V_stockService : RootService<V_stock>, IV_stockService
    {
        public V_stockService(IRepository<V_stock> repository) : base(repository)
        { }
    }
}
