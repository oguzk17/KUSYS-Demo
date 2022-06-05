using KUSYS_Demo.Application.Features.Commands.Authentication.SignUpUser;
using Microsoft.AspNetCore.Mvc;

namespace KUSYS_Demo.WebAPI.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class AuthController:ControllerBase
    {

        [HttpPost("SignUp")]
        public async Task<IActionResult> SignUp(SignUpUserCommand signUpUserCommand)
        {



            return Ok();

        }


    }
}
