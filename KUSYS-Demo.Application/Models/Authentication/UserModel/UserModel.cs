using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KUSYS_Demo.Application.Models.Authentication.UserModel
{
    public class UserModel
    {

        public int Id { get; set; }
        public string Email { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Password { get; set; }

        public IList<string> Roles { get; set; }
    }
}
