using LocationVehicule.Controler;
using LocationVehicule.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LocationVehicule.Repositories
{
    public class AdministrateurRepository : IAdministrateurRepository <Administrateur>
    {
        readonly LcationContext _locationContext;

        public AdministrateurRepository( LcationContext context)
        {
            _locationContext = context;
        }

        public IEnumerable<Administrateur> GetAllAdministrateur()
        {
            return _locationContext.Administrateur.ToList();
        }
    }
}
