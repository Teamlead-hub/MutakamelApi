using CleanBase.Entities;
using CleanBusiness.Declarations;
using Microsoft.Identity.Client;


namespace CleanAPI.Controllers
{
    public class RiskGroupController(IRiskGroup service) : BaseController<RiskGroup>(service)
    {

    }
}
