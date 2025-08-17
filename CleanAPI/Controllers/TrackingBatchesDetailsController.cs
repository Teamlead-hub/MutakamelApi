using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class TrackingBatchesDetailsController(ITrackingBatchesDetailsService service) : BaseController<TrackingBatchesDetails>(service)
    {
    }
}
