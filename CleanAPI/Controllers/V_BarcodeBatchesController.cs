using CleanBase.Entities;
using CleanBusiness.Declarations;
using Microsoft.Identity.Client;


namespace CleanAPI.Controllers
{
    public class V_BarcodeBatchesController(IV_BarcodeBatches service) : BaseController<V_BarcodeBatches>(service)
    {

    }
}
