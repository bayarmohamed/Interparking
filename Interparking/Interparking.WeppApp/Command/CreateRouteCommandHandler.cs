using Interparking.DAL.Abstraction;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Routing;

namespace Interparking.WeppApp.Command
{
    public class CreateRouteCommandHandler : IRequestHandler<CreateRouteCommand, bool>
    {
        readonly IRouteRepository routeRepository;
        public CreateRouteCommandHandler(IRouteRepository routeRepository)
        {
            this.routeRepository = routeRepository;
        }
        public Task<bool> Handle(CreateRouteCommand request, CancellationToken cancellationToken)
        {
            routeRepository.CreateRoute(new DAL.Model.RouteModel
            {
                Departure = request.Departure,
                Destination = request.Destination,
                IdClient = request.IdClient,
                LatDeparture = request.LatDeparture,
                LatDestination = request.LatDestination,
                LongDeparture = request.LongDeparture,
                LongDestination = request.LongDestination
            });
            return Task.FromResult(true);
        }
    }
}