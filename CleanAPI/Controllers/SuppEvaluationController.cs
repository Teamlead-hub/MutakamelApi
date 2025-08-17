using CleanBase.Entities;
using CleanBusiness.Declarations;
using Microsoft.Identity.Client;


namespace CleanAPI.Controllers
{
    public class SuppEvaluationController(ISuppEvaluation service) : BaseController<SuppEvaluation>(service)
    {

    }
}
