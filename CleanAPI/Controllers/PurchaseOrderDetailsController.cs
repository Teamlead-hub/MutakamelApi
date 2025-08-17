using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class PurchaseOrderDetailsController(IPurchaseOrderDetails service) : BaseController<PurchaseOrderDetails>(service)
    {
    }
}
