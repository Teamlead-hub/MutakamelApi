using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class CityController(ICityService service) :BaseController<City>(service)
    {
    }
}
