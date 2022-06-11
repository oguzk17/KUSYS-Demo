using KUSYS_Demo.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KUSYS_Demo.Domain.Entities
{
    public  class Person: BaseEntity
    {

        public string  FirstName { get; set; }
        public string LastName { get; set; }
        public string Company { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Location { get; set; } //Enum yapcaz
        public string Info { get; set; }





    }
}
