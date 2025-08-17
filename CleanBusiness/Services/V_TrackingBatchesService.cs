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
    public class V_TrackingBatchesService : RootService<V_TrackingBatches>, IV_TrackingBatchesService
    {
        public V_TrackingBatchesService(IRepository<V_TrackingBatches> repository) : base(repository)
        { }
    }
}
