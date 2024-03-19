using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tobeto.Lesson6Assignment.Entity
{
    public class InMemoryDatabase
    {
        public InMemoryDatabase()
        {
            Students = new List<Student>()
            {
                new Student()
                {
                    ID = 1,
                    FirstName = "Ali",
                    LastName = "Yaldız",
                    SchoolNumber = "123"
                },
                new Student()
                {
                    ID = 2,
                    FirstName = "Veli",
                    LastName = "Ateş",
                    SchoolNumber = "456"
                }
            };
            Teachers = new List<Teacher>() 
            { 
            new Teacher(){ID =1,FirstName ="Zehra",LastName ="Özcan",Branch ="Matematik" },
            new Teacher(){ID =2,FirstName ="Ceyda",LastName ="Kodlabalı",Branch ="Türkçe" },
            new Teacher(){ID =3,FirstName ="Sedat",LastName ="Akkuş",Branch ="Bilgisayar" }
            };
        }

       public List<T> Set<T>() 
        {
            if (typeof(T) == typeof(Student))
            {
                return Students as List<T>;
            }
            else if (typeof(T) == typeof(Teacher) )
            {
                return Teachers as List<T>;
            }
            return new List<T>();
        }  

        public List<Student> Students { get; set; }
        public List<Teacher> Teachers { get; set; }
    }
}
