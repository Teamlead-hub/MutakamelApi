using CleanBase.Entities;
using CleanBusiness.Declarations;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CleanAPI.Controllers
{
    public class V_LetterOfCreditController(IV_LetterOfCredit service) : BaseController<V_LetterOfCredit>(service)
    {

    }
    
}
