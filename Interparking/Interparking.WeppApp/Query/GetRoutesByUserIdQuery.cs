using Interparking.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Interparking.WeppApp.Query
{
    public class GetRoutesByUserIdQuery:IQuery<List<RouteModel>>
    {
        public UserRequestById user { get; set; }
    }
}