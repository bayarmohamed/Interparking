using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interparking.DAL.Urls
{
    public static class Urls
    {
        public static readonly string UserApiUri = @"http://localhost:52838/User";
        public static readonly string AuthApiUri = @"http://localhost:52838/Auth";
        public static readonly string RouteApiUri = @"http://localhost:52838/Routes";
        public static readonly string RouteByIdApiUri = @"http://localhost:52838/RoutesById";
        public static readonly string RoutesByRouteIdApiUri = @"http://localhost:52838/RoutesByRouteId";
        public static readonly string ParkingApiUri = @"http://localhost:52838/Parkings";
    }
}
