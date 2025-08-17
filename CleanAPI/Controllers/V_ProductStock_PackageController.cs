using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class V_ProductStock_PackageController(IV_ProductStock_PackageService service):BaseController<V_ProductStock_Package>(service)
    {
    }
}
