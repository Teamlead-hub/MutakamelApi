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
    public class V_StockBatchesService : RootService<V_StockBatches>, IV_StockBatchesService
    {
        public V_StockBatchesService(IRepository<V_StockBatches> repository) : base(repository)
        { }
    }
}
