using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class PurchaseOrderMainController(IPurchaseOrderMain service) : BaseController<PurchaseOrderMain>(service)
    {
    }
}
