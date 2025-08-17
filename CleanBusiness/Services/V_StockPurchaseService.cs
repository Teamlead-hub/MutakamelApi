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
    public class V_StockPurchaseService : RootService<V_StockPurchase>, IV_StockPurchaseService
    {
        public V_StockPurchaseService(IRepository<V_StockPurchase> repository) : base(repository)
        { }
    }
}
