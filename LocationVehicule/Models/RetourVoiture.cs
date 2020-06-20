using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LocationVehicule.Models
{
    public class RetourVoiture
    {
        public int RetourVoitureId { get; set; }
        public int LocationId { get; set; }
        public DateTime DateRetour { get; set; }


    }
}
