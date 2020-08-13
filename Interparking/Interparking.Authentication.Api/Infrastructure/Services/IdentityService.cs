using Interparking.Authentication.Api.Dto;
using Interparking.Authentication.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Interparking.Authentication.Api.Infrastructure.Services
{
    public class IdentityService : IIdentityService
    {
        IdentityContext context;
        public IdentityService(IdentityContext context)
        {
            this.context = context;       
        }
        public User GetUser(Credential credential)
        {
           return  context.Users.SingleOrDefault(x => x.Email.Equals(credential.email.ToLowerInvariant()));

        }
    }
}
