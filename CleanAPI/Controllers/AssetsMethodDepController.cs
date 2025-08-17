using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class AssetsMethodDepController(IAssetsMethodDep service) : BaseController<AssetsMethodDep>(service)
    {
    }
}
