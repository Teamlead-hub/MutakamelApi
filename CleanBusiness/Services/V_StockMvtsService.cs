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
    public class V_StockMvtsService : RootService<V_StockMvts>, IV_StockMvts
    {
        public V_StockMvtsService(IRepository<V_StockMvts> repository) : base(repository)
        { }
    }
}
