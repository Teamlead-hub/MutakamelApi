using CleanBase.Entities;
using CleanBusiness.Declarations;
using CleanBusiness.Services;

namespace CleanAPI.Controllers
{
    public class V_Pmvts_BatchesController(IV_Pmvts_BatchesService service) : BaseController<V_Pmvts_Batches>(service)
    {
    }
}
