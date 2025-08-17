using CleanBase.Entities;
using CleanBusiness.Declarations;
using Microsoft.Identity.Client;


namespace CleanAPI.Controllers
{
    public class SupContractInfoController(ISupContractInfo service) : BaseController<SupContractInfo>(service)
    {

    }
}
