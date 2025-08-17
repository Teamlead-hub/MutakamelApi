using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class QualificationController(IQualification service) : BaseController<Qualification>(service)
    {
    }
}
