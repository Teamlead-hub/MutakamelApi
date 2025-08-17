using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class EvaluationMarksController(IEvaluationMarks service) : BaseController<EvaluationMarks>(service)
    {
    }
}
