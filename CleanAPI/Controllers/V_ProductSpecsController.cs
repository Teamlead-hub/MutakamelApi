using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class V_ProductSpecsController(IV_ProductSpecsService service) : BaseController<V_ProductSpecs>(service)
    {
    }
}
