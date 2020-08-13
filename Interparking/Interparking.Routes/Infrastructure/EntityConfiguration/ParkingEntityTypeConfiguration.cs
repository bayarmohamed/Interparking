using Interparking.Routes.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Interparking.Routes.Infrastructure.EntityConfiguration
{
    public class ParkingEntityTypeConfiguration : IEntityTypeConfiguration<Parking>
    {
        public void Configure(EntityTypeBuilder<Parking> builder)
        {
            builder.ToTable("Parkings");

            builder.HasKey(m => m.ID);

            builder.Property(m => m.Name)
                .HasColumnName("Name")
                .IsRequired();

            builder.Property(m => m.Address)
                .HasColumnName("Address")
                .IsRequired();

            builder.HasData(
           new Parking { ID = 1, Name = "Minigolf (Knokke-Heist)", Address = "Sparrendreef 103, 8300 Knokke-Heist" },
           new Parking { ID = 2, Name = "Beffroi (Namur)", Address = "Place d'Armes, 5000 Namur" },
           new Parking { ID = 3, Name = "Saint Georges (Liège)", Address = "Quai de la Batte, 4000 Liège" },
           new Parking { ID = 4, Name = "CCN (Bruxelles)", Address = "Rue du Progrès 80, 1000 Bruxelles" },
           new Parking { ID = 5, Name = "Woluwe Shopping Center (Bruxelles)", Address = "Boulevard de la Woluwe, 70 bte 127, 1200 Bruxelles" }
           );
            
        }
    }
}
