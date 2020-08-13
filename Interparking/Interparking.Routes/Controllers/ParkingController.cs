using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Interparking.Routes.Infrastructure.Repositories;
using Interparking.Routes.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Interparking.Routes.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class ParkingController : ControllerBase
    {
        readonly IParkingRepository parkingRepository;

        public ParkingController(IParkingRepository parkingRepository)
        {
            this.parkingRepository = parkingRepository;
        }
        // GET: api/Parking
        [HttpGet]
        public IEnumerable<Parking> Get()
        {
            return parkingRepository.GetAllParking();
        }

       
    }
}
