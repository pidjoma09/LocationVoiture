using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace LocationVehicule.Repositories
{
    public interface IRepository<T> where T:class
    {
        IEnumerable<T> GetAll();
        T get(int Id);
        IEnumerable<T> Find(Expression predicate);
        void Add(T entity);
        void AddRange(IEnumerable<T> entities);
        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entities);

    }
}
