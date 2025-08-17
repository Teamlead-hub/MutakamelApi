using CleanBase.Entities;
using CleanBusiness.Declarations;
using Microsoft.Identity.Client;


namespace CleanAPI.Controllers
{
    public class DeviationMainController(IDeviationMain service) : BaseController<DeviationMain>(service)
    {

    }
}
