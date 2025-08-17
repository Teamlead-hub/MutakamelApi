using CleanBase.Entities;
using CleanBusiness.Declarations;
using Microsoft.Identity.Client;


namespace CleanAPI.Controllers
{
    public class SupEvaluationRateController(ISupEvaluationRate service) : BaseController<SupEvaluationRate>(service)
    {

    }
}
