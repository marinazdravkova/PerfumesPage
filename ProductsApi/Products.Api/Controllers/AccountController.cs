using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Products.Application.Common.Interfaces;
using Products.Application.Common.Models;
using Products.Infrastructure.Identity;

namespace Products.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IIdentityService _service;

        public AccountController(IIdentityService service)
        {
            _service = service;
        }
        [AllowAnonymous]
        [HttpPost("register")]
        public async Task<IActionResult> RegisterUser(RegisterModelDto registerModel)
        {
            var registered = await _service.Register(registerModel);

            if (!registered.isValid)
            {
                return BadRequest(registered.ResponseMessage);
            }

            return Ok(registered.ResponseMessage);
        }

        [HttpPost("login")]
        public async Task<IActionResult> SignInUser(SignInModelDto signInModel)
        {
            var resultToken = await _service.SignIn(signInModel);

            if (resultToken is null)
            {
                return BadRequest();

            }
            return Ok(resultToken);
            
        }

        [HttpGet("getUserByUserName")]
        public async Task<IActionResult> GetUserByUserName(string userName)
        {
            var result = await _service.GetUserByUserName(userName);

            if (result is null)
            {
                return BadRequest($"User with {userName} username doesnt exist!");
            }

            return Ok(result);
        }
    }
}
