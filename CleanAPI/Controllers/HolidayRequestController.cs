using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class HolidayRequestController(IHolidayRequest service) : BaseController<HolidayRequest>(service)
    {
    }
}
