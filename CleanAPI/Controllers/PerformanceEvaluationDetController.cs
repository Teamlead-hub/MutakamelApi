using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class PerformanceEvaluationDetController(IPerformanceEvaluationDet service) : BaseController<PerformanceEvaluationDet>(service)
    {
    }
}
