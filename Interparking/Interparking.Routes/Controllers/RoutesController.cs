using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Interparking.Routes.Dto;
using Interparking.Routes.Infrastructure.Repositories;
using Interparking.Routes.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Interparking.Routes.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class RoutesController : ControllerBase
    {
        readonly IRouteRepository routeRepository;

        public RoutesController(IRouteRepository routeRepository)
        {
            this.routeRepository = routeRepository;
        }
        // GET: api/Routes
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        
        [HttpPost]
        [Route("[action]")]
        public IEnumerable<RouteDto> PostUserById([FromBody] UserRequestByID user)
        {
            return routeRepository.GetRoutesByUserId(user.UserId).ToList();
        }


        [HttpPost]
        [Route("[action]")]
        public RouteDto PostRouteById([FromBody] RouteRequestedById route)
        {
            return routeRepository.GetRoutesByRouteId(route.RouteId);
        }

        // POST: api/Routes
        [HttpPost]
        public void Post([FromBody] RouteDto route)
        {
            var newroute = new Route
            {
                IdClient= route.IdClient,
                ParkingDeparture = new Location (route.LongDeparture,route.LatDeparture,route.Departure),
                ParkingDestination = new Location(route.LongDestination, route.LatDestination, route.Destination)
            };
            routeRepository.CreateRoute(newroute);
        }

        // PUT: api/Routes/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {

        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
