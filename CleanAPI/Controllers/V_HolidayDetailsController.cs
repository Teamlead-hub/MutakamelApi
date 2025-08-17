using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class V_HolidayDetailsController(IV_HolidayDetails service) : BaseController<V_HolidayDetails>(service)
    {
    }
}
