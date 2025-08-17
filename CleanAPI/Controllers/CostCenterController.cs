using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class CostCenterController(ICostCenterService service) : BaseController<CostCenter>(service)
    {
    }
}
