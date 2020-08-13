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
    public class UserRepository : IUserRepository
    {
        public async Task AddUser(UserModel user)
        {
           
            var client = new HttpClient();

            var json = JsonConvert.SerializeObject(user);
            HttpContent content = new StringContent(json);

            content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");

            var response = await client.PostAsync(Urls.Urls.UserApiUri, content);

        }

        public async Task<TokenModel> GetToekn(CredentialModel credential)
        {
            var client = new HttpClient();

            var json = JsonConvert.SerializeObject(credential);
            HttpContent content = new StringContent(json);

            content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");

            var response =  client.PostAsync(Urls.Urls.AuthApiUri, content).GetAwaiter().GetResult();
           
            string responseBody = await response.Content.ReadAsStringAsync();

            var token = JsonConvert.DeserializeObject<TokenModel>(responseBody);

            return token;
        }
    }
}
