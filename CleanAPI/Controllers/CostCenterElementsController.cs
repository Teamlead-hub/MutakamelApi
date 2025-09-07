using CleanBase.Entities;
using CleanBusiness.Declarations;
using Microsoft.Identity.Client;


namespace CleanAPI.Controllers
{
    public class CostCenterElementsController(ICostCenterElements service) : BaseController<CostCenterElements>(service)
    {

    }
}
