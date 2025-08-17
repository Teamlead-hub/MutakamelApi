using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class V_Asset_PurchaseDetController(IV_Asset_PurchaseDet service) : BaseController<V_Asset_PurchaseDet>(service)
    {
    }
}
