using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class AreaController(IAreaService service) :BaseController<Area>(service)
    {
    }
}
