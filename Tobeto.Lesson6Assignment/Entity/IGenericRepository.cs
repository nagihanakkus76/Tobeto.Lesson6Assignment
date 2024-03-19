using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tobeto.Lesson6Assignment.Entity
{
    public interface IGenericRepository<T> where T : BaseEntity
    {
        void Add(T t);
        void Remove(T t);
        List<T> GetAll();
        T GetByID(int id);
    }
}
