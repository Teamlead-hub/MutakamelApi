using CleanBase.Entities;
using CleanBusiness.Declarations;
using CleanBusiness.Services;

namespace CleanAPI.Controllers
{
    public class PosOperatorsController(IPosOperators service) : BaseController<PosOperators>(service)
    {
    }
}
