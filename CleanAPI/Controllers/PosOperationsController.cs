using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class PosOperationsController(IPosOperations service) : BaseController<PosOperations>(service)
    {
    }
}
