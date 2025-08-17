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
    public class TrackingBatchesService : RootService<TrackingBatches>, ITrackingBatchesService
    {
        public TrackingBatchesService(IRepository<TrackingBatches> repository) : base(repository)
        { }
    }
}
