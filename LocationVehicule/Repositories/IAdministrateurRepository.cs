using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LocationVehicule.Repositories
{
    interface IAdministrateurRepository<T>
    {
        IEnumerable<T> GetAllAdministrateur();
    }
}
