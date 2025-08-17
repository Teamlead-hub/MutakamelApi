using CleanBase.Entities;
using CleanBusiness.Declarations;
using Microsoft.Identity.Client;


namespace CleanAPI.Controllers
{
    public class SupEvaluationInfoController(ISupEvaluationInfo service) : BaseController<SupEvaluationInfo>(service)
    {

    }
}
