using Interparking.DAL.Model;
using Interparking.WeppApp.Models.Routes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Interparking.WeppApp.Query
{
    public class GetRouteByRouteIDQuery:IQuery<RouteModel>
    {
        public int IdRoute { get; set; }
    }
}