using CleanBase.Entities;
using CleanBusiness.Declarations;
using CleanBusiness.Services;

namespace CleanAPI.Controllers
{
    public class V_PCustomerListController(IV_PCustomerListService service) : BaseController<V_PCustomerList>(service)
    {
    }
}
