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
    public class V_ProductBatchesService : RootService<V_ProductBatches>, IV_ProductBatchesService
    {
        public V_ProductBatchesService(IRepository<V_ProductBatches> repository) : base(repository)
        { }
    }
}
