using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KUSYS_Demo.Application.Features.Commands.Authentication.SignUpUser
{
    public class SignUpUserCommand :IRequest<int>
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string FirstNmae { get; set; }
        public string LastName { get; set; }
    }
}
