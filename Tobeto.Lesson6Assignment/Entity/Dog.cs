using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tobeto.Lesson6Assignment.Entity
{
    public class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Hav hav!");
        }
    }
}
