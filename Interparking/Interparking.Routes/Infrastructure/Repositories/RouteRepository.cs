using Interparking.Routes.Dto;
using Interparking.Routes.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Interparking.Routes.Infrastructure.Repositories
{
    public class RouteRepository : IRouteRepository
    {
        readonly RouteContext context;
        public RouteRepository(RouteContext context)
        {
            this.context = context;
        }
        public  void CreateRoute(Route route)
        {
            context.Routes.Add(route);
            context.SaveChanges();
        }
        public RouteDto GetRoutesByRouteId(int routeId)
        {
            return context.Routes
                .Where(route => route.Id == routeId)
                .Select(route =>  new RouteDto
                {
                    IdClient = route.IdClient,
                    Id = route.Id,
                    Departure = route.ParkingDeparture.Parking,
                    Destination = route.ParkingDestination.Parking,
                    LatDeparture = route.ParkingDeparture.Lattitude,
                    LongDeparture = route.ParkingDeparture.Longitude,
                    LatDestination = route.ParkingDestination.Lattitude,
                    LongDestination = route.ParkingDestination.Longitude,
                    Distance = route.Distance,
                    Fuel = route.Fuel
                }).SingleOrDefault();
        }

        public IEnumerable<RouteDto> GetRoutesByUserId(string userId)
        {
            return context.Routes
                .Where(route => route.IdClient.Equals(userId))
                .Select(route => new RouteDto
                {
                    IdClient = route.IdClient,
                    Id = route.Id,
                    Departure = route.ParkingDeparture.Parking,
                    Destination = route.ParkingDestination.Parking,
                    LatDeparture = route.ParkingDeparture.Lattitude,
                    LongDeparture = route.ParkingDeparture.Longitude,
                    LatDestination = route.ParkingDestination.Lattitude,
                    LongDestination = route.ParkingDestination.Longitude,
                    Distance = route.Distance,
                    Fuel = route.Fuel
                });
        }
    private RouteDto AdapToRouteDto(Route route)
    {
        return new RouteDto
        {
            IdClient = route.IdClient,
            Id = route.Id,
            Departure = route.ParkingDeparture.Parking,
            Destination = route.ParkingDestination.Parking,
            LatDeparture = route.ParkingDeparture.Lattitude,
            LongDeparture = route.ParkingDeparture.Longitude,
            LatDestination = route.ParkingDestination.Lattitude,
            LongDestination = route.ParkingDestination.Longitude,
            Distance = route.Distance,
            Fuel = route.Fuel
        };
    }
    }
}
