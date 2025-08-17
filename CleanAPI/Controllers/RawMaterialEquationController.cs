using CleanBase.Entities;
using CleanBusiness.Declarations;
using CleanBusiness.Services;

namespace CleanAPI.Controllers
{
    public class RawMaterialEquationController(IRawMaterialEquationService service) : BaseController<RawMaterialEquation>(service)
    {
    }
}
