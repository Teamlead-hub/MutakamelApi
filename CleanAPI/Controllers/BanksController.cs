using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class BanksController(IBanks service) : BaseController<Banks>(service)
    {
    }
}
