using Interparking.Routes.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Interparking.Routes.Infrastructure.EntityConfiguration
{
    public class RouteEntityTypeConfiguration : IEntityTypeConfiguration<Route>
    {
        public void Configure(EntityTypeBuilder<Route> builder)
        {
            builder.ToTable("Routes");

            builder.HasKey(m => m.Id);

            builder.Property(m => m.IdClient)
                .HasColumnName("IdClient")
                .IsRequired();

            builder.Property(m => m.Fuel)
               .HasColumnName("Fuel").HasColumnType("float")
               .IsRequired();

            builder.Property(m => m.Distance)
              .HasColumnName("Distance").HasColumnType("float")
              .IsRequired();

            builder.OwnsOne(x => x.ParkingDeparture).Property(m => m.Parking)
                .HasColumnName("Departure")
                
                .IsRequired();

            builder.OwnsOne(x=> x.ParkingDestination).Property(m => m.Parking)
                .HasColumnName("Destination")
                .IsRequired();

            


        }
    }
}
