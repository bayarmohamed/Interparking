using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Interparking.Routes.Model
{
    public class Route
    {
        public int Id { get; set; }
        public string IdClient { get; set; }
        public decimal Distance { get; set; }
        public decimal Fuel { get; set; }
        public Location ParkingDeparture { get; set; }
        public Location ParkingDestination { get; set; }

    }
}
