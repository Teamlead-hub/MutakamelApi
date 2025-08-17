using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class V_TrackingBatchesDetailsController(IV_TrackingBatchesDetailsService service) : BaseController<V_TrackingBatchesDetails>(service)
    {
    }
}
