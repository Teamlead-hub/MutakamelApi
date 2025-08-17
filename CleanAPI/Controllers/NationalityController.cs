using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class NationalityController(INationality service) : BaseController<Nationality>(service)
    {
    }
}
