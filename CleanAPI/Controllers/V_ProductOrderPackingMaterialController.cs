using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class V_ProductOrderPackingMaterialController(IV_ProductOrderPackingMaterialService service):BaseController<V_ProductOrderPackingMaterial>(service)
    {
    }
}
