using Interparking.DAL.Abstraction;
using Interparking.DAL.Model;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Web;

namespace Interparking.WeppApp.Query
{
    public class GetRouteByRouteIDQueryHandler : IRequestHandler<GetRouteByRouteIDQuery, RouteModel>
    {
        readonly IRouteRepository routeRepository;
        public GetRouteByRouteIDQueryHandler(IRouteRepository routeRepository)
        {
            this.routeRepository = routeRepository;
        }

        public Task<RouteModel> Handle(GetRouteByRouteIDQuery request, CancellationToken cancellationToken)
        {
            var route = routeRepository.GetRoutesByRouteId(new RouteRequestedByID { RouteId = request.IdRoute });
            return Task.FromResult(route.Result);
        }
    }
}