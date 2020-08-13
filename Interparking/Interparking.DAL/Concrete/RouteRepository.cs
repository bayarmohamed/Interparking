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
    public class RouteRepository : IRouteRepository
    {
        public async Task CreateRoute(RouteModel route)
        {
            using (var client = new HttpClient())
            {
                var json = JsonConvert.SerializeObject(route);
                HttpContent content = new StringContent(json);

                content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");

                var response = await client.PostAsync(Urls.Urls.RouteApiUri, content);
            }
        }

        public async Task<IEnumerable<RouteModel>> GetRoutesByUserId(UserRequestById user)
        {
            using (var client = new HttpClient())
            {
                var json = JsonConvert.SerializeObject(user);
                HttpContent content = new StringContent(json);

                content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");

                var response =  client.PostAsync(Urls.Urls.RouteByIdApiUri, content).GetAwaiter().GetResult();

                string responseBody = await response.Content.ReadAsStringAsync();
                var routes = JsonConvert.DeserializeObject<List<RouteModel>>(responseBody);
                return routes;
            }
        }

        public async Task<RouteModel> GetRoutesByRouteId(RouteRequestedByID routeRequest)
        {
            using (var client = new HttpClient())
            {
                var json = JsonConvert.SerializeObject(routeRequest);
                HttpContent content = new StringContent(json);

                content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");

                var response = client.PostAsync(Urls.Urls.RoutesByRouteIdApiUri, content).GetAwaiter().GetResult();

                string responseBody = await response.Content.ReadAsStringAsync();
                var route = JsonConvert.DeserializeObject<RouteModel>(responseBody);
                return route;
            }
        }
    }
}
