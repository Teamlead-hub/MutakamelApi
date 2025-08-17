using CleanBase.Entities;
using CleanBusiness.Declarations;
using Microsoft.Identity.Client;


namespace CleanAPI.Controllers
{
    public class V_SupEvaluationInfoController(IV_SupEvaluationInfo service) : BaseController<V_SupEvaluationInfo>(service)
    {

    }
}
