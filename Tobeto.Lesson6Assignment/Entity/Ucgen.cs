using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tobeto.Lesson6Assignment.Entity
{
    public class Triangle : Shape
    {
        public Triangle(int a, int b, int c) : base(a,"Üçgen")
        {
            A= a;
            B = b;
            C = c;
            Console.WriteLine(ShapeName + " nesnesi oluşturuldu.");
        }

        public override void CalculatePerimeter()
        {
            int calculatePerimeter = A+B+C;
            Console.WriteLine("Çevre : " + calculatePerimeter);
        }
        public int B { get; set; }
        public int C { get; set; }

    }
}
