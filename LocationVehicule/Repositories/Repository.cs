using LocationVehicule.Controler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace LocationVehicule.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        public readonly LcationContext _locationContext;
        public Repository(LcationContext locationContext)
        {
            _locationContext =locationContext;
        }
        public void Add(T entity)
        {
            _locationContext.Set<T>().Add(entity);
                 
        }

        public void AddRange(IEnumerable<T> entities)
        {
            _locationContext.Set<T>().AddRange(entities);         
        }

        public IEnumerable<T> Find(Expression predicate)
        {
            throw new NotImplementedException();
        }

        public T get(int Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetAllAdministrateur()
        {
            throw new NotImplementedException();
        }

        public void Remove(T entity)
        {
            throw new NotImplementedException();
        }

        public void RemoveRange(IEnumerable<T> entities)
        {
            throw new NotImplementedException();
        }

        
    }
}
