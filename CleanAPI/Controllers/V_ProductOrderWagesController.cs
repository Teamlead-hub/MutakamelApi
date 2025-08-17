using CleanBase.Entities;
using CleanBusiness.Declarations;
using CleanBusiness.Services;

namespace CleanAPI.Controllers
{
    public class V_ProductOrderWagesController(IV_ProductOrderWagesService service) :BaseController<V_ProductOrderWages>(service)
    {
    }
}
