using LocationVehicule.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace LocationVehicule.Repositories
{
    public class VoitureRepository : IVoitureRepository
    {
        
        public void Add(Voiture voiture)
        {
            
        }

        public void AddRange(IEnumerable<Voiture> entities)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Voiture> Find(Expression predicate)
        {
            throw new NotImplementedException();
        }

        public Voiture get(int Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Voiture> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Voiture> GetVoiture()
        {
            throw new NotImplementedException();
        }

        public void Remove(Voiture entity)
        {
            throw new NotImplementedException();
        }

        public void RemoveRange(IEnumerable<Voiture> entities)
        {
            throw new NotImplementedException();
        }
    }
}
