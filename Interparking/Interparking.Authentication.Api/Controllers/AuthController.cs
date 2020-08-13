using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Interparking.Authentication.Api.Dto;
using Interparking.Authentication.Api.Infrastructure.Services;
using Interparking.Authentication.Api.Models;
using Interparking.Users.Api.Infrastructure.Security;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

namespace Interparking.Authentication.Api.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        IConfiguration Configuration;
        IIdentityService service;
        public AuthController(IConfiguration Configuration, IIdentityService service)
        {
            this.Configuration = Configuration;
            this.service = service;
        }
        
        [HttpPost]
        public IActionResult Login([FromBody]Credential credential)
        {
            IActionResult response = Ok(new { isAuthenticated = false, token = "" });
            var user = service.GetUser(credential);

            if (user != null)
            {
                var salt = user.Salt;
                var hashedPassword = Protector.SaltAndHashPassword(credential.password, salt);
                if (user.HashedPassword == hashedPassword)
                {
                    var tokenString = GenerateJSONWebToken(user);
                    response = Ok(new { userid = user.ID, isAuthenticated = true, token = tokenString });
                }
              
            }

            return response;
        }
        private string GenerateJSONWebToken(User userInfo)
        {
            var now = DateTime.UtcNow;

            var claims = new Claim[]
            {
            new Claim(JwtRegisteredClaimNames.Sub, userInfo.Name),
            new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
            new Claim(JwtRegisteredClaimNames.Iat, now.ToUniversalTime().ToString(), ClaimValueTypes.Integer64)
            };

            var signingKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(Configuration["Jwt:Key"]));

            var jwt = new JwtSecurityToken(
                issuer: Configuration["Jwt:Issuer"],
                audience: Configuration["Jwt:Issuer"],
                claims: claims,
                notBefore: now,
                expires: now.Add(TimeSpan.FromMinutes(20)),
                signingCredentials: new SigningCredentials(signingKey, SecurityAlgorithms.HmacSha256)
            );
            return new JwtSecurityTokenHandler().WriteToken(jwt);
        }

     


    }
}
