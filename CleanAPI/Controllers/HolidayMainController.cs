using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class HolidayMainController(IHolidayMain service) : BaseController<HolidayMain>(service)
    {
    }
}
