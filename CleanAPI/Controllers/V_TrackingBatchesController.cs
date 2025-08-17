using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class V_TrackingBatchesController(IV_TrackingBatchesService service) : BaseController<V_TrackingBatches>(service)
    {
    }
}
