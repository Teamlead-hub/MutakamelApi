using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class PosOperatorsdetController(IPosOperatorsdet service) : BaseController<PosOperatorsdet>(service)
    {
    }
}
