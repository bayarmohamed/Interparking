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
    public class GetRoutesByUserIdHandler : IRequestHandler<GetRoutesByUserIdQuery, List<RouteModel>>
    {
        readonly IRouteRepository routeRepository;
        public GetRoutesByUserIdHandler(IRouteRepository routeRepository)
        {
            this.routeRepository = routeRepository;
        }
        public Task<List<RouteModel>> Handle(GetRoutesByUserIdQuery request, CancellationToken cancellationToken)
        {
            var routes = routeRepository.GetRoutesByUserId(request.user).GetAwaiter().GetResult();
            return Task.FromResult(routes.ToList());
        }
    }
}