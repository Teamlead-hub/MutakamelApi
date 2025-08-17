using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class V_ProductBatchDetailsController(IV_ProductBatchDetailsService service) : BaseController<V_ProductBatchDetails>(service)
    {
    }
}
