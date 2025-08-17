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
    public class V_StockDistService : RootService<V_StockDist>, IV_StockDistService
    {
        public V_StockDistService(IRepository<V_StockDist> repository) : base(repository)
        { }
    }
}
