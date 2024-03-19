using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tobeto.Lesson6Assignment.Entity
{
    public class Teacher :BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; } 
        public string Branch { get; set; }
    }
}
