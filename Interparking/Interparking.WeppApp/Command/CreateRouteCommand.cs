using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Interparking.WeppApp.Command
{
    public class CreateRouteCommand:ICommand<bool>
    {
        public string IdClient { get; set; }
        public string Departure { get; set; }
        public string Destination { get; set; }
        public string LongDeparture { get; set; }
        public string LongDestination { get; set; }
        public string LatDeparture { get; set; }
        public string LatDestination { get; set; }
    }
}