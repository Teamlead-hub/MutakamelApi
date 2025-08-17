using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class V_ProductBatchesController(IV_ProductBatchesService service) : BaseController<V_ProductBatches>(service)
    {
    }
}
