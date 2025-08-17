using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class TrackingBatchesController(ITrackingBatchesService service) : BaseController<TrackingBatches>(service)
    {
    }
}
