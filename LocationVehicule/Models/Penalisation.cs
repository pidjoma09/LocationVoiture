using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LocationVehicule.Models
{
    public class Penalisation
    {
        public int PenalisationId { get; set; }
        public int locationId { get; set; }
        public double Cout { get; set; }
        public string Raison { get; set; }
    }
}
