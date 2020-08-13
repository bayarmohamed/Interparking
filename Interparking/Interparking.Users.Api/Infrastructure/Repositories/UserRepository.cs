using Interparking.Users.Api.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Interparking.Users.Api.Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        UserContext dbContext;
        public UserRepository(UserContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public  void AddUser(User user)
        {
            dbContext.Users.Add(user);
            dbContext.SaveChanges();
        }
    }
}
