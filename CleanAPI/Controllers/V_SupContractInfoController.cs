using CleanBase.Entities;
using CleanBusiness.Declarations;
using Microsoft.Identity.Client;


namespace CleanAPI.Controllers
{
    public class V_SupContractInfoController(IV_SupContractInfo service) : BaseController<V_SupContractInfo>(service)
    {

    }
}
