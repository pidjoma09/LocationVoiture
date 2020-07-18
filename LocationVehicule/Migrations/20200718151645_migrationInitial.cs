using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LocationVehicule.Migrations
{
    public partial class migrationInitial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Administrateur",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Login = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Administrateur", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    ClientId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Login = table.Column<string>(nullable: true),
                    PieceIndentite = table.Column<int>(nullable: false),
                    Nom = table.Column<string>(nullable: true),
                    Prenom = table.Column<string>(nullable: true),
                    DateNaissance = table.Column<DateTime>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    Adresse = table.Column<string>(nullable: true),
                    Telephone = table.Column<string>(nullable: true),
                    DateInscription = table.Column<DateTime>(nullable: false),
                    Password = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.ClientId);
                });

            migrationBuilder.CreateTable(
                name: "Location",
                columns: table => new
                {
                    LocationId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdClient = table.Column<int>(nullable: false),
                    IdVoiture = table.Column<int>(nullable: false),
                    Datelocation = table.Column<DateTime>(nullable: false),
                    DateDébut = table.Column<DateTime>(nullable: false),
                    Datefin = table.Column<DateTime>(nullable: false),
                    TypePaiement = table.Column<int>(nullable: false),
                    Montant = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Location", x => x.LocationId);
                });

            migrationBuilder.CreateTable(
                name: "Penalisation",
                columns: table => new
                {
                    PenalisationId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    locationId = table.Column<int>(nullable: false),
                    Cout = table.Column<double>(nullable: false),
                    Raison = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Penalisation", x => x.PenalisationId);
                });

            migrationBuilder.CreateTable(
                name: "RetourVoiture",
                columns: table => new
                {
                    RetourVoitureId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LocationId = table.Column<int>(nullable: false),
                    DateRetour = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RetourVoiture", x => x.RetourVoitureId);
                });

            migrationBuilder.CreateTable(
                name: "Voiture",
                columns: table => new
                {
                    VoitureId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Matricule = table.Column<string>(nullable: true),
                    Modele = table.Column<string>(nullable: true),
                    Couleurs = table.Column<string>(nullable: true),
                    Puissance = table.Column<string>(nullable: true),
                    Categorie = table.Column<string>(nullable: true),
                    CountParHeure = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Voiture", x => x.VoitureId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Administrateur");

            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropTable(
                name: "Location");

            migrationBuilder.DropTable(
                name: "Penalisation");

            migrationBuilder.DropTable(
                name: "RetourVoiture");

            migrationBuilder.DropTable(
                name: "Voiture");
        }
    }
}
