using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class LeadsAndDealsController(ILeadsAndDealsService service) :BaseController<LeadsAndDeals>(service)
    {
    }
}
