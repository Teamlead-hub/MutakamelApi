using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class V_LeadsAndDealsController(IV_LeadsAndDealsService service) :BaseController<V_LeadsAndDeals>(service)
    {
    }
}
