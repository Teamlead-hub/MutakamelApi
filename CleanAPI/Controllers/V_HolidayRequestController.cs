using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class V_HolidayRequestController(IV_HolidayRequest service) : BaseController<V_HolidayRequest>(service)
    {
    }
}
