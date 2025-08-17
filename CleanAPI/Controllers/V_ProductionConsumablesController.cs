using CleanBase.Entities;
using CleanBusiness.Declarations;
using Microsoft.Identity.Client;


namespace CleanAPI.Controllers
{
    public class V_ProductionConsumablesController(IV_ProductionConsumablesService service) : BaseController<V_ProductionConsumables>(service)
    {

    }
}
