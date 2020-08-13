using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Interparking.WeppApp.Models.Routes
{
    public class RouteViewModel
    {
        public string IdClient { get; set; }
        public int Id { get; set; }
        public string Departure { get; set; }
        public string Destination { get; set; }
        public string LongDeparture { get; set; }
        public string LongDestination { get; set; }
        public string LatDeparture { get; set; }
        public string LatDestination { get; set; }
        public decimal Distance { get; set; }
        public decimal Fuel { get; set; }

        public List<SelectListItem> Parkings { get; set; }
        
    }
}