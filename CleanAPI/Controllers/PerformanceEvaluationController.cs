using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class PerformanceEvaluationController(IPerformanceEvaluation service) : BaseController<PerformanceEvaluation>(service)
    {
    }
}
