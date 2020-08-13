using Interparking.Routes.Infrastructure.EntityConfiguration;
using Interparking.Routes.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Interparking.Routes.Infrastructure
{
    public class RouteContext:DbContext
    {
        public RouteContext(DbContextOptions<RouteContext> options) : base(options)
        {

        }
        public DbSet<Route> Routes { get; set; }
        public DbSet<Parking> Parkings { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new RouteEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new ParkingEntityTypeConfiguration());

        }
    }
}
