using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class V_HolidayMainController(IV_HolidayMain service) : BaseController<V_HolidayMain>(service)
    {
    }
}
