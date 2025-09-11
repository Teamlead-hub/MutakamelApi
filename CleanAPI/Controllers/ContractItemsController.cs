using CleanBase.Entities;
using CleanBusiness.Declarations;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CleanAPI.Controllers
{
    public class ContractItemsController(IContractItems service) : BaseController<ContractItems>(service)
    {
    }
}
