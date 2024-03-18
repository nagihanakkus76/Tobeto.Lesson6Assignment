using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tobeto.Lesson6Assignment.Entity
{
    public class Square : Shape
    {
        public Square(int a) : base(a,"Kare")
        {
            A = a;
             Console.WriteLine(ShapeName + " nesnesi oluşturuldu.");

        }

        public override void CalculatePerimeter()
        {
          int calculatePerimeter = 4 * A ;
            Console.WriteLine("Çevre : " + calculatePerimeter);
        }

    }
}
