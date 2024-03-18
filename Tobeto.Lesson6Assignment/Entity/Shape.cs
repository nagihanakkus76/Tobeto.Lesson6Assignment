using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tobeto.Lesson6Assignment.Entity
{
    public class Shape
    {
        public virtual void Draw() 
        {
            Console.WriteLine("Şekil Çiziliyor.");
        }
    }
}
