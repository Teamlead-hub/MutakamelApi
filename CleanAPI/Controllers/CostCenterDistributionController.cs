using CleanBase.Entities;
using CleanBusiness.Declarations;
using Microsoft.Identity.Client;


namespace CleanAPI.Controllers
{
    public class CostCenterDistributionController(ICostCenterDistribution service) : BaseController<CostCenterDistribution>(service)
    {

    }
}
