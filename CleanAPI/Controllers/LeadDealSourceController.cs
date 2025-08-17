using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class LeadDealSourceController(ILeadDealSourceService service) :BaseController<LeadDealSource>(service)
    {
    }
}
