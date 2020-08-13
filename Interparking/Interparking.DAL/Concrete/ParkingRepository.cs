using Interparking.DAL.Abstraction;
using Interparking.DAL.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Interparking.DAL.Concrete
{
    public class ParkingRepository : IParkingRepository
    {
      
        public async Task<IEnumerable<ParkingModel>> GetALL()
        {
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(Urls.Urls.ParkingApiUri).ConfigureAwait(false);
                string responseBody = await response.Content.ReadAsStringAsync();
                var parkings = JsonConvert.DeserializeObject<List<ParkingModel>>(responseBody);
                return parkings;
            }
        }
    }
}
