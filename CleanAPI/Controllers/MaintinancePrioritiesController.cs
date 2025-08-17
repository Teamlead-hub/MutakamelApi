using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class MaintinancePrioritiesController(IMaintinancePriorities service) : BaseController<MaintinancePriorities>(service)
    {
    }
}
