using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tobeto.Lesson6Assignment.Entity
{
    public class Opel : Car
    {
        public Opel() : base("Opel")
        {
            Console.WriteLine(Brand + " nesnesi oluşturuldu.");
        }
    }
}
