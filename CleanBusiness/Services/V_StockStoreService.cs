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
    public class V_StockStoreService : RootService<V_StockStore>, IV_StockStoreService
    {
        public V_StockStoreService(IRepository<V_StockStore> repository) : base(repository)
        { }
    }
}
