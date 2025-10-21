using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class V_LeadDealActivityController(IV_LeadDealActivityService service) :BaseController<V_LeadDealActivity>(service)
    {
    }
}
