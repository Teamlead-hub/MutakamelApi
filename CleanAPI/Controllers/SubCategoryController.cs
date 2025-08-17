using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class SubCategoryController(ISubCategoryService service) : BaseController<SubCategory>(service)
    {
    }
}
