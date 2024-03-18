using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tobeto.Lesson6Assignment.Models
{
    public class Teacher : User
    {
        public Teacher()
        {
            Console.WriteLine("Teacher nesnesi oluşturuldu.");
        }
        public Branch branch { get; set; }
    }
}
