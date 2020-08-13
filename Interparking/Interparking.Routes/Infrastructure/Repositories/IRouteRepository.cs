using Interparking.Routes.Dto;
using Interparking.Routes.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Interparking.Routes.Infrastructure.Repositories
{
    public interface IRouteRepository
    {
        void CreateRoute(Route route);
        IEnumerable<RouteDto> GetRoutesByUserId(string userId);
        RouteDto GetRoutesByRouteId(int routeId);
    }
}
