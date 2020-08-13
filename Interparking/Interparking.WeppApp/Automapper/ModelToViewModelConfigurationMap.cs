using AutoMapper;
using Interparking.DAL.Model;
using Interparking.WeppApp.Models.Routes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Interparking.WeppApp.Automapper
{
    public class ModelToViewModelConfigurationMap:Profile
    {
        public ModelToViewModelConfigurationMap()
        {
            var map = CreateMap<ParkingModel, ParkingViewModel>();
            map.ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name));
            map.ForMember(dest => dest.Address, opt => opt.MapFrom(src => src.Address));
           
        }
    }
}