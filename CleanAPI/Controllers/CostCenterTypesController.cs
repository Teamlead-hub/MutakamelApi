using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class CostCenterTypesController(ICostCenterTypes service) : BaseController<CostCenterTypes>(service)
    {
    }
}
