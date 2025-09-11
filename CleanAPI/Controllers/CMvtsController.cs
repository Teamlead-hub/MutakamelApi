using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class CMvtsController(ICMvts service) : BaseController<CMvts>(service)
    {
    }
}
