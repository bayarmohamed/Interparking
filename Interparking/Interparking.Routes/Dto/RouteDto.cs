using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Interparking.Routes.Dto
{
    public class RouteDto
    {
        public string IdClient { get; set; }
        public int Id { get; set; }
        public string Departure { get; set; }
        public string Destination { get; set; }
        public decimal Distance { get; set; }
        public decimal Fuel { get; set; }
        public string LongDeparture { get; set; }
        public string LongDestination{ get; set; }
        public string LatDeparture { get; set; }
        public string LatDestination { get; set; }
    }
}
