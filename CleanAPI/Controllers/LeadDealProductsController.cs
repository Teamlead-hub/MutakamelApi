using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class LeadDealProductsController(ILeadDealProductsService service) :BaseController<LeadDealProducts>(service)
    {
    }
}
