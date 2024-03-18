using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tobeto.Lesson6Assignment.Entity
{
    public class Rectangle : Shape
    {
        public Rectangle(int a, int b) : base(a,"Dikdörtgen")
        {
            A = a;
            B = b;
            Console.WriteLine(ShapeName + " nesnesi oluşturuldu.");
        }

        public override void CalculatePerimeter()
        {
            int calculatePerimeter = 2*(A+B);
            Console.WriteLine("Çevre : " + calculatePerimeter);

        }

        public int B { get; set; }
    }
}
