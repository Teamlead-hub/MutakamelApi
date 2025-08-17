using CleanBase.Entities;
using CleanBusiness.Declarations;
using Microsoft.Identity.Client;


namespace CleanAPI.Controllers
{
    public class RiskCategoryController(IRiskCategory service) : BaseController<RiskCategory>(service)
    {

    }
}
