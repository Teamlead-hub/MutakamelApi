using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class ContractsController(IContracts service) : BaseController<Contracts>(service)
    {
    }
}
