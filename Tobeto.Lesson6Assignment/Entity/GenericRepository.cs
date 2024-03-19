using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Tobeto.Lesson6Assignment.Entity
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {
        private readonly InMemoryDatabase _database = new();
        public void Add(T data)
        {
            _database.Set<T>().Add(data);
        }

        public List<T> GetAll()
        {
            return _database.Set<T>();
        }

        public T GetByID(int id)
        {
            return _database.Set<T>().Find(x => x.ID == id);
;        }

        public void Remove(T data)
        {
            _database.Set<T>().Remove(data);
        }
    }
}
