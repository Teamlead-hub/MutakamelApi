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
    public class V_StockDetailsService : RootService<V_StockDetails>, IV_StockDetailsService
    {
        public V_StockDetailsService(IRepository<V_StockDetails> repository) : base(repository)
        { }
    }
}
