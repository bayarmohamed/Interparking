using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Interparking.Users.Api.Dto;
using Interparking.Users.Api.Infrastructure.Repositories;
using Interparking.Users.Api.Infrastructure.Security;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Interparking.Users.Api.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        IUserRepository userRepository;
        ILogger<UserController> logger;
        public UserController(IUserRepository userRepository,
            ILogger<UserController> logger)
        {
            this.userRepository = userRepository;
            this.logger = logger;
        }
        // GET: api/User
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/User/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/User
        [HttpPost]
        public void Post([FromBody] UserDto user)
        {
            try
            {
                var salt = Protector.GetSalt();
                userRepository.AddUser(new Model.User
                {
                    ID = Guid.NewGuid().ToString(),
                    Email = user.Email,
                    HashedPassword = Protector.SaltAndHashPassword(user.Password, salt),
                    Name = user.Name,
                    Salt = salt
                });
            }
            catch (Exception ex)
            {
                logger.LogError(ex.InnerException.Message);
            }
          
        }

        // PUT: api/User/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
