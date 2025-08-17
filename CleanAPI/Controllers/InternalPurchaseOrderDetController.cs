using CleanBase.Entities;
using CleanBusiness.Declarations;
using Microsoft.Identity.Client;


namespace CleanAPI.Controllers
{
    public class InternalPurchaseOrderDetController(IInternalPurchaseOrderDet service) : BaseController<InternalPurchaseOrderDet>(service)
    {

    }
}
