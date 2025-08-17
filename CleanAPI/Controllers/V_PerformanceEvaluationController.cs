using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class V_PerformanceEvaluationController(IV_PerformanceEvaluation service) : BaseController<V_PerformanceEvaluation>(service)
    {
    }
}
