using CleanBase.Entities;
using CleanBusiness.Declarations;
using CleanBusiness.Services;
using Microsoft.AspNetCore.Mvc;

namespace CleanAPI.Controllers
{
    //[Route("api/[controller]")]
    //[ApiController]
    //public class V_webpagesUsersController : BaseController<V_webpagesUsers>
    //{
    //    private readonly IV_webpagesUsers _service; //  Inject Interface for User Service

    //    public V_webpagesUsersController(V_webpagesUsersService service) : base(service)
    //    {
    //        _service = service;
    //    }

    //    [HttpPost("login")]
    //    public async Task<IActionResult> Login([FromBody] V_webpagesUsers loginDto)
    //    {

    //        var token = await _service.CreateToken(loginDto); // Call CreateToken via interface

    //        return Ok(new { Token = token });
    //
    //}

    public class V_webpagesUsersController : BaseController<V_webpagesUsers>
    {
        private readonly IV_webpagesUsers _service;

        public V_webpagesUsersController(IV_webpagesUsers service) : base(service)
        {
            _service = service;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] V_webpagesUsers loginDto)
        {
            if (loginDto == null)
                return BadRequest("Invalid login data.");

            var token = await _service.CreateToken(loginDto);
            return Ok(new { Token = token });
        }
    }

}
