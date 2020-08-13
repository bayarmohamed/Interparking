using Interparking.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interparking.DAL.Abstraction
{
    public interface IUserRepository
    {
        Task AddUser(UserModel user);
        Task<TokenModel> GetToekn(CredentialModel credential);
    }
}
