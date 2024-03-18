using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tobeto.Lesson6Assignment.Entity
{
    public class Car
    {

        public Car(string brand)
        {
            Brand = brand;
        }
        public int Id { get; set; }
        public string Brand { get;  }
        public string Model { get; set; }
        public int KM { get; set; }
        public decimal Price { get; set; }
    }
}
