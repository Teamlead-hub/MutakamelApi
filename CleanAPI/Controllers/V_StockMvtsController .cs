using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class V_StockMvtsController(IV_StockMvts service) : BaseController<V_StockMvts>(service)
    {
    }
}
