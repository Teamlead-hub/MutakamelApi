using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class EvaluationElementsController(IEvaluationElements service) : BaseController<EvaluationElements>(service)
    {
    }
}
