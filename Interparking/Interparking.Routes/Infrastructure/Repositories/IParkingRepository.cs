using Interparking.Routes.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Interparking.Routes.Infrastructure.Repositories
{
    public interface IParkingRepository
    {
        IEnumerable<Parking> GetAllParking();
    }
}
