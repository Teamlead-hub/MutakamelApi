using CleanBase.Entities;
using CleanBusiness.Declarations;
using Microsoft.Identity.Client;


namespace CleanAPI.Controllers
{
    public class InternalPurchaseOrderMainController(IInternalPurchaseOrderMain service) : BaseController<InternalPurchaseOrderMain>(service)
    {

    }
}
