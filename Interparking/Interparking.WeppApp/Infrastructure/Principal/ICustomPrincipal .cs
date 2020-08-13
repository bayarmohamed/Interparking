using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Interparking.WeppApp.Infrastructure.Principal
{
    interface ICustomPrincipal : IPrincipal
    {
        string Id { get; set; }
        string Email { get; set; }
        string Token { get; set; }
    }
}
