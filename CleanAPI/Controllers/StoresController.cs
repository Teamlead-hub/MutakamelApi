using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class StoresController(IStores service) : BaseController<Stores>(service)
    {
    }
}
