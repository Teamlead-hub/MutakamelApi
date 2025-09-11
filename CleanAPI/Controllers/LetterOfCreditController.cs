using CleanBase.Entities;
using CleanBusiness.Declarations;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CleanAPI.Controllers
{
    public class LetterOfCreditController(ILetterOfCredit service) : BaseController<LetterOfCredit>(service)
    {

    }
}
