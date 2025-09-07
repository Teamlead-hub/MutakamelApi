using CleanBase.Entities;
using CleanBusiness.Declarations;
using Microsoft.Identity.Client;


namespace CleanAPI.Controllers
{
    public class CostCenterDistributionDetController(ICostCenterDistributionDet service) : BaseController<CostCenterDistributionDet>(service)
    {

    }
}
