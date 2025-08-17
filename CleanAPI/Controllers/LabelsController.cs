using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class LabelsController(ILabelsService service) :BaseController<Labels>(service)
    {
    }
}
