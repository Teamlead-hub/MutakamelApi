using CleanBase.Entities;
using CleanBusiness.Declarations;
using CleanBusiness.Services;

namespace CleanAPI.Controllers
{
    public class V_RawMaterialEquationController(IV_RawMaterialEquationService service) : BaseController<V_RawMaterialEquation>(service)
    {
    }
}
