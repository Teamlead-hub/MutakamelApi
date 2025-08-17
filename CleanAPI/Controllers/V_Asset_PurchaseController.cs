using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class V_Asset_PurchaseController(IV_Asset_Purchase service) : BaseController<V_Asset_Purchase>(service)
    {
    }
}
