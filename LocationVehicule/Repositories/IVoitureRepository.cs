using LocationVehicule.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LocationVehicule.Repositories
{
    public interface IVoitureRepository:IRepository<Voiture>
    {
        IEnumerable<Voiture> GetVoiture();
        void Add(Voiture voiture);
    }
}
