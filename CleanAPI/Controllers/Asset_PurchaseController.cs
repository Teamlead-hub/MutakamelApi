using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class Asset_PurchaseController(IAsset_Purchase service) : BaseController<Asset_Purchase>(service)
    {
    }
}
