﻿// <auto-generated />
using System;
using LocationVehicule.Controler;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LocationVehicule.Migrations
{
    [DbContext(typeof(LcationContext))]
    partial class LcationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("LocationVehicule.Models.Administrateur", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Login")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Administrateur");
                });

            modelBuilder.Entity("LocationVehicule.Models.Client", b =>
                {
                    b.Property<int>("ClientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adresse")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateInscription")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateNaissance")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Login")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nom")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PieceIndentite")
                        .HasColumnType("int");

                    b.Property<string>("Prenom")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telephone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ClientId");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("LocationVehicule.Models.Location", b =>
                {
                    b.Property<int>("LocationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateDébut")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Datefin")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Datelocation")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdClient")
                        .HasColumnType("int");

                    b.Property<int>("IdVoiture")
                        .HasColumnType("int");

                    b.Property<double>("Montant")
                        .HasColumnType("float");

                    b.Property<int>("TypePaiement")
                        .HasColumnType("int");

                    b.HasKey("LocationId");

                    b.ToTable("Location");
                });

            modelBuilder.Entity("LocationVehicule.Models.Penalisation", b =>
                {
                    b.Property<int>("PenalisationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Cout")
                        .HasColumnType("float");

                    b.Property<string>("Raison")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("locationId")
                        .HasColumnType("int");

                    b.HasKey("PenalisationId");

                    b.ToTable("Penalisation");
                });

            modelBuilder.Entity("LocationVehicule.Models.RetourVoiture", b =>
                {
                    b.Property<int>("RetourVoitureId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateRetour")
                        .HasColumnType("datetime2");

                    b.Property<int>("LocationId")
                        .HasColumnType("int");

                    b.HasKey("RetourVoitureId");

                    b.ToTable("RetourVoiture");
                });

            modelBuilder.Entity("LocationVehicule.Models.Voiture", b =>
                {
                    b.Property<int>("VoitureId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Categorie")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Couleurs")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("CountParHeure")
                        .HasColumnType("float");

                    b.Property<string>("Matricule")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Modele")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Puissance")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("VoitureId");

                    b.ToTable("Voiture1");
                });
#pragma warning restore 612, 618
        }
    }
}
