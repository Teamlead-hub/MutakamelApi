using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class V_StockBatchesController(IV_StockBatchesService service) : BaseController<V_StockBatches>(service)
    {
    }
}
