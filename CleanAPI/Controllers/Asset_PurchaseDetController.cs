using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class Asset_PurchaseDetController(IAsset_PurchaseDet service) : BaseController<Asset_PurchaseDet>(service)
    {
    }
}
