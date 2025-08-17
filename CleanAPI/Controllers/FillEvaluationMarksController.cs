using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class FillEvaluationMarksController(IFillEvaluationMarks service) : BaseController<FillEvaluationMarks>(service)
    {

    }
}
