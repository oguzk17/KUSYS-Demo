using KUSYS_Demo.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KUSYS_Demo.Domain
{
    public class Student :BaseEntity
    {
        public string Name { get; set; }    
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }  
    
    }
}
