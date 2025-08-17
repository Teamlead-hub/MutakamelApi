using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class AcGroupsController(IAcGroups service) : BaseController<AcGroups>(service)
    {
    }
}
