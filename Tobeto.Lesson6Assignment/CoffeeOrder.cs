using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tobeto.Lesson6Assignment
{
    /// <summary>
    /// Kahve siparişi oluşturan bir classtır.
    /// </summary>
    public class CoffeeOrder
    {
        private string coffeeType;
        private string size;
        private List<string> exstras;
        /// <summary>
        /// Kahve türünü ve boyunu istediğimiz ctor dır.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="size"></param>
        public CoffeeOrder(string type, string size)
        {
            coffeeType = type;
            this.size = size;
            exstras = new List<string>();
        }

        /// <summary>
        /// Kahveye extra ürün eklememizi sağlayan bir metottur..
        /// </summary>
        /// <param name="exstra"></param>
        public void AddExstra(string exstra)
        {
            exstras.Add(exstra);
        }

        /// <summary>
        /// Kahveden istediğimiz ürünleri çıkarmamızı sağlayan bir metottur.
        /// </summary>
        /// <param name="exstra"></param>
        public void RemoveExstra(string exstra) 
        {  
            exstras.Remove(exstra); 
        }

        /// <summary>
        /// Siparişin detaylarını veren metottur.
        /// </summary>
        public void OrderDetails() 
        {
            Console.WriteLine("Kahve türü : " + coffeeType);
            Console.WriteLine("Boyut : " + size);
            Console.WriteLine("Ekstralar : ");
            foreach (string exstra in exstras) 
            {
                Console.WriteLine("- " + exstra);
            }
        }
    }
}
