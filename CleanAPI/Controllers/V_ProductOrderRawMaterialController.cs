using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class V_ProductOrderRawMaterialController(IV_ProductOrderRawMaterialService service):BaseController<V_ProductOrderRawMaterial>(service)
    {
    }
}
