using AutoMapper;
using Interparking.DAL.Model;
using Interparking.WeppApp.Models.Routes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Interparking.WeppApp.Automapper
{
    public class RouteToRouteViewModelConfigurationMap:Profile
    {
        public RouteToRouteViewModelConfigurationMap()
        {
            var map = CreateMap<RouteModel, RouteViewModel>();
            map.ForMember(dest => dest.Departure, opt => opt.MapFrom(src => src.Departure));
            map.ForMember(dest => dest.Destination, opt => opt.MapFrom(src => src.Destination));
            map.ForMember(dest => dest.LongDeparture, opt => opt.MapFrom(src => src.LongDeparture));
            map.ForMember(dest => dest.LongDestination, opt => opt.MapFrom(src => src.LongDestination));
            map.ForMember(dest => dest.LatDeparture, opt => opt.MapFrom(src => src.LatDeparture));
            map.ForMember(dest => dest.LatDestination, opt => opt.MapFrom(src => src.LatDestination));
            
        }
    }
}