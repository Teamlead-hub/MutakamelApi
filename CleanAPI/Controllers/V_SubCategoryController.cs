using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class V_SubCategoryController(IV_SubCategoryService service) : BaseController<V_SubCategory>(service)
    {
    }
}
