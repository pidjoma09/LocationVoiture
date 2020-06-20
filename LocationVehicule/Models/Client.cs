    using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace LocationVehicule.Models
{
     public class Client
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public int PieceIndentite { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public DateTime DateNaissance { get; set;}
        public string Email { get; set; }
        public string Adresse { get; set; }
        public string Telephone { get; set; }
        public DateTime DateInscription { get; set; }
        public string Password { get; set; }

    }
}