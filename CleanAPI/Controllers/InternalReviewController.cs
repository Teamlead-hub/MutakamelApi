using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class InternalReviewController(IInternalReviewService service) : BaseController<InternalReview>(service)
    {
    }
}
