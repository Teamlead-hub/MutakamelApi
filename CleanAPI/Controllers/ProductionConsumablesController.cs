using CleanBase.Entities;
using CleanBusiness.Declarations;
using Microsoft.Identity.Client;


namespace CleanAPI.Controllers
{
    public class ProductionConsumablesController(IProductionConsumablesService service) : BaseController<ProductionConsumables>(service)
    {

    }
}
