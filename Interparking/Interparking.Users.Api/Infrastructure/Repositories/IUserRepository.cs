using Interparking.Users.Api.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Interparking.Users.Api.Infrastructure.Repositories
{
    public interface IUserRepository
    {
        void AddUser(User user);
    }
}
