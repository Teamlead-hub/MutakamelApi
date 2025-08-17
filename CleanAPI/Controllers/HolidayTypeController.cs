using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class HolidayTypeController(IHolidayType service) : BaseController<HolidayType>(service)
    {
    }
}
