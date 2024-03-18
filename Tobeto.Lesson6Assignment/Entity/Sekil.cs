using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tobeto.Lesson6Assignment.Entity
{
    public class Shape
    {
        public Shape(int x , string y) 
        {
            A = x;
            ShapeName = y;
        }
        public virtual void CalculatePerimeter() 
        {
            int calculatePerimeter = A;
        }
        public int A { get; set; }
        public string ShapeName { get; } 
    }
}
