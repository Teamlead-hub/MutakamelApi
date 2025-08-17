using CleanBase.Entities;
using CleanBusiness.Declarations;
using CleanBusiness.Services;

namespace CleanAPI.Controllers
{
    public class UnitsController(IUnitsService service) : BaseController<Units>(service)
    {
    }
}
