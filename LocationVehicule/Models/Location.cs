using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LocationVehicule.Models
{
    public class Location
    {
        public int LocationId { get; set; }
        public int IdClient { get; set; }
        public int IdVoiture { get; set; }
        public DateTime Datelocation { get; set; }
        public DateTime DateDébut { get; set; }
        public DateTime Datefin { get; set; }
        public int TypePaiement { get; set; }
        public double Montant { get; set; }
    }
}
