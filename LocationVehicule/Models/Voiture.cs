using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace LocationVehicule.Models
{
    public class Voiture
    {
        public int  VoitureId { get; set; }
        public string Matricule { get; set; }
        public string Modele { get; set; }
        public string Couleurs { get; set; }
        public string Puissance { get; set; }
        public string Categorie { get; set; }
        public double CountParHeure { get; set; }
    }
}
