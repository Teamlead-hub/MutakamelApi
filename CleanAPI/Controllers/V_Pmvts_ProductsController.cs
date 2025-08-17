using CleanBase.Entities;
using CleanBusiness.Declarations;
using CleanBusiness.Services;

namespace CleanAPI.Controllers
{
    public class V_Pmvts_ProductsController(IV_Pmvts_ProductsService service) : BaseController<V_Pmvts_Products>(service)
    {
    }
}
