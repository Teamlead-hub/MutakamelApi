using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class CategoryController(ICategoryService service) : BaseController<Category>(service)
    {
    }
}
