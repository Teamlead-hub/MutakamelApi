using CleanBase.Entities;
using CleanBusiness.Declarations;

namespace CleanAPI.Controllers
{
    public class V_AssetsTransferController(IV_AssetsTransfer service) : BaseController<V_AssetsTransfer>(service)
    {
    }
}
