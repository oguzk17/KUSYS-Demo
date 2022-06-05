using KUSYS_Demo.Application.Features.Commands.Authentication.SignUpUser;
using KUSYS_Demo.Application.Features.Queries.Authentication.GetUser;
using KUSYS_Demo.Application.Models.Authentication.UserModel;
using KUSYS_Demo.Application.Settings;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace KUSYS_Demo.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        public readonly IMediator _mediator;
        private readonly JwtSettings _jwtSettings;
        public AuthController(IMediator mediator,
            IOptionsSnapshot<JwtSettings> jwtSettings
            )
        {
            _mediator = mediator;
            _jwtSettings = jwtSettings.Value;
        }
        [HttpPost("SignUp")]
        public async Task<IActionResult> SignUp(SignUpUserCommand signUpUserCommand)
        { 
            var result = await _mediator.Send(signUpUserCommand);

            if (result != 0)
                return Ok();

            return BadRequest("User not created");
        }

      
    }
}
    

