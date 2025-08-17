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
    public class V_TrackingBatchesDetailsService : RootService<V_TrackingBatchesDetails>, IV_TrackingBatchesDetailsService
    {
        public V_TrackingBatchesDetailsService(IRepository<V_TrackingBatchesDetails> repository) : base(repository)
        { }
    }
}
