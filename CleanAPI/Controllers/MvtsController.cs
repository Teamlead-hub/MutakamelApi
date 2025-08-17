using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class MvtsController(IMvts service) : BaseController<Mvts>(service)
    {
    }
}
