using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class FactoryController(IFactoryService service) :BaseController<Factory>(service)
    {
    }
}
