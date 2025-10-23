using CleanBase.Entities;
using CleanBusiness.Declarations;
using Microsoft.Identity.Client;


namespace CleanAPI.Controllers
{
    public class V_CostCenterDistributionController(IV_CostCenterDistribution service) : BaseController<V_CostCenterDistribution>(service)
    {

    }
}
