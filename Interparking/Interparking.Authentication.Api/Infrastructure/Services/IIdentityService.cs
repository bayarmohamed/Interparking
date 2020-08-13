using Interparking.Authentication.Api.Dto;
using Interparking.Authentication.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Interparking.Authentication.Api.Infrastructure.Services
{
    public interface IIdentityService
    {
        User GetUser(Credential credential);
    }
}
