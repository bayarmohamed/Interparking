using Interparking.Routes.Infrastructure.ValueObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Interparking.Routes.Model
{
    public class Location:ValueObject
    {
        public string Longitude { get; private set; }
        public string Lattitude { get; private set; }

        public string Parking { get; private set; }

        private Location() { }

        public Location(string longitude, string lattitude,string parking)
        {
            Longitude = longitude;
            Lattitude = lattitude;
            Parking = parking;
        }

        public override string ToString()
        {
            return  $"{Longitude}, {Lattitude}, {Parking} ";
        }
        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return Longitude;
            yield return Lattitude;
            yield return Parking;
        }
    }
}
