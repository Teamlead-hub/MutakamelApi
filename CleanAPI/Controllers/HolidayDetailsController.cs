using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class HolidayDetailsController(IHolidayDetails service) : BaseController<HolidayDetails>(service)
    {
    }
}
