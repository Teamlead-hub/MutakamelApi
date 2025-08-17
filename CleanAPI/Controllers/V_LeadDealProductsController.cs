using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class V_LeadDealProductsController(IV_LeadDealProductsService service) :BaseController<V_LeadDealProducts>(service)
    {
    }
}
