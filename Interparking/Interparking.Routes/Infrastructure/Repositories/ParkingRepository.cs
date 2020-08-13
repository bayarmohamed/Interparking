using Interparking.Routes.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Interparking.Routes.Infrastructure.Repositories
{
    public class ParkingRepository : IParkingRepository
    {
        readonly RouteContext context;
       
        public ParkingRepository(RouteContext context)
        {
            this.context = context;
        }
        public IEnumerable<Parking> GetAllParking()
        {
            return context.Parkings.ToList();
        }
    }
}
