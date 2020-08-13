﻿// <auto-generated />
using Interparking.Routes.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Interparking.Routes.Migrations
{
    [DbContext(typeof(RouteContext))]
    [Migration("20200812161614_first")]
    partial class first
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Interparking.Routes.Model.Parking", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnName("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Parkings");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Address = "Sparrendreef 103, 8300 Knokke-Heist",
                            Name = "Minigolf (Knokke-Heist)"
                        },
                        new
                        {
                            ID = 2,
                            Address = "Place d'Armes, 5000 Namur",
                            Name = "Beffroi (Namur)"
                        },
                        new
                        {
                            ID = 3,
                            Address = "Quai de la Batte, 4000 Liège",
                            Name = "Saint Georges (Liège)"
                        },
                        new
                        {
                            ID = 4,
                            Address = "Rue du Progrès 80, 1000 Bruxelles",
                            Name = "CCN (Bruxelles)"
                        },
                        new
                        {
                            ID = 5,
                            Address = "Boulevard de la Woluwe, 70 bte 127, 1200 Bruxelles",
                            Name = "Woluwe Shopping Center (Bruxelles)"
                        });
                });

            modelBuilder.Entity("Interparking.Routes.Model.Route", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Distance")
                        .HasColumnName("Distance")
                        .HasColumnType("float");

                    b.Property<double>("Fuel")
                        .HasColumnName("Fuel")
                        .HasColumnType("float");

                    b.Property<string>("IdClient")
                        .IsRequired()
                        .HasColumnName("IdClient")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Routes");
                });

            modelBuilder.Entity("Interparking.Routes.Model.Route", b =>
                {
                    b.OwnsOne("Interparking.Routes.Model.Location", "ParkingDeparture", b1 =>
                        {
                            b1.Property<int>("RouteId")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("int")
                                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                            b1.Property<string>("Lattitude")
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("Longitude")
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("Parking")
                                .IsRequired()
                                .HasColumnName("Departure")
                                .HasColumnType("nvarchar(max)");

                            b1.HasKey("RouteId");

                            b1.ToTable("Routes");

                            b1.WithOwner()
                                .HasForeignKey("RouteId");
                        });

                    b.OwnsOne("Interparking.Routes.Model.Location", "ParkingDestination", b1 =>
                        {
                            b1.Property<int>("RouteId")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("int")
                                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                            b1.Property<string>("Lattitude")
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("Longitude")
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("Parking")
                                .IsRequired()
                                .HasColumnName("Destination")
                                .HasColumnType("nvarchar(max)");

                            b1.HasKey("RouteId");

                            b1.ToTable("Routes");

                            b1.WithOwner()
                                .HasForeignKey("RouteId");
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
