using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//using System.Data.Entity;
using Microsoft.EntityFrameworkCore;
using System.Configuration;
using LocationVehicule.Models;

namespace LocationVehicule.Controler
{
    public class LcationContext : DbContext
    {


        public DbSet<Administrateur> Administrateur { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Location> Location { get; set; }
        public DbSet<Penalisation> Penalisation { get; set; }
        public DbSet<RetourVoiture> RetourVoiture { get; set; }
        public DbSet<Voiture> Voiture { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        { 
            options.UseSqlServer(ConfigurationManager.ConnectionStrings["BloggingDatabase"].ConnectionString);
        }
    }
}
