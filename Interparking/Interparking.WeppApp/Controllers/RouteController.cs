using AutoMapper;
using Interparking.DAL.Abstraction;
using Interparking.DAL.Model;
using Interparking.WeppApp.Command;
using Interparking.WeppApp.Infrastructure.Principal;
using Interparking.WeppApp.Models.Routes;
using Interparking.WeppApp.Query;
using MediatR;
using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Interparking.WeppApp.Controllers
{
    [Authorize]
    public class RouteController : Controller
    {
        IMediator mediator;
        IMapper mapper;
        IParkingRepository parkingRepository;

        public RouteController(IMediator mediator, IMapper mapper, IParkingRepository parkingRepository)
        {
            this.mediator = mediator;
            this.mapper = mapper;
            this.parkingRepository = parkingRepository;
        }
        // GET: Route
        public ActionResult Index()
        {
            var parkings = parkingRepository.GetALL().GetAwaiter().GetResult();
            var model = new RouteViewModel();
            
            model.Parkings = parkings.Select(x => new SelectListItem { 
            Text = x.Name,
            Value = x.Address
            }).ToList();

            return View(model);
        }


        public ActionResult CreateRoute(RouteViewModel route)
        {
            var model = mapper.Map<CreateRouteCommand>(route);
            model.IdClient = (HttpContext.User as CustomPrincipal).Id;
            mediator.Send(model);
            return RedirectToAction("Index");
        }

        public ActionResult Routes()
        {
            var userId = (HttpContext.User as CustomPrincipal).Id;
            var routes = mediator.Send(new GetRoutesByUserIdQuery { user = new UserRequestById { UserId = userId } }).GetAwaiter().GetResult();

            //var model = mapper.Map<RouteViewModel>(routes);
            var model = routes.Select(x => new RouteViewModel
            {
                Id = x.Id,
                Departure = x.Departure,
                Destination = x.Destination,
                IdClient = x.IdClient,
                LatDeparture = x.LatDeparture,
                LatDestination = x.LatDestination,
                LongDeparture = x.LongDeparture,
                LongDestination = x.LongDestination,
                Fuel = x.Fuel,
                Distance= x.Distance
                
            });
            return View(model);
        }
        public ActionResult UpdateRoute(int routeId)
        {
            var model = mediator.Send(
                new GetRouteByRouteIDQuery
                { 
                    IdRoute = routeId
                }).GetAwaiter().GetResult();

            var viewmodel = mapper.Map<RouteViewModel>(model);

            return View(viewmodel);
        }

        [HttpPost]
        public ActionResult UpdateRoute(RouteViewModel route)
        {
            return View();
        }

    }
}