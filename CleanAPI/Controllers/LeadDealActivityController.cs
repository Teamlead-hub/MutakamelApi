using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class LeadDealActivityController(ILeadDealActivityService service) :BaseController<LeadDealActivity>(service)
    {
    }
}
