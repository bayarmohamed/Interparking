using Interparking.Routes.Model;
using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Interparking.Routes.Infrastructure.Repositories.Cached
{
    public class CachedParkingRepository : IParkingRepository
    {
        IParkingRepository parkingRepository;
        ICachedMemory memory;


        public CachedParkingRepository(IParkingRepository parkingRepository, ICachedMemory memory)
        {
            this.parkingRepository = parkingRepository;
            this.memory = memory;
        }

        public IEnumerable<Parking> GetAllParking()
        {
            var cache = memory.GetCache();

            if (cache.Get("Parkings") == null)
            {
                memory.GetCache().Set("Parkings", parkingRepository.GetAllParking(), absoluteExpiration: DateTime.Now.AddMinutes(1));
            }

            return (IEnumerable<Parking>)cache.Get("Parkings"); ;
        }
    }
}
