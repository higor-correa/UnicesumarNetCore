using Hbsis.Ambev.Unicesumar.Canteen.Api.Configurations.Authentications;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Hbsis.Ambev.Unicesumar.Canteen.Api.Controllers
{
    [ApiController]
    [Route("api/authentication")]
    [AllowAnonymous]
    public class AuthenticationController : ControllerBase
    {
        private readonly ILoginService _loginService;

        public AuthenticationController(ILoginService loginService)
        {
            _loginService = loginService;
        }

        public async Task<IActionResult> Login([FromBody] LoginRequest login)
        {
            var token = await _loginService.GenerateTokenAsync(login.Login, login.Password);

            return string.IsNullOrWhiteSpace(token)
                ? (IActionResult)Unauthorized()
                : Ok(new { Token = token });
        }
    }
}
