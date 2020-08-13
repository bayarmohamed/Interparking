using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Interparking.WeppApp.Infrastructure.Principal
{
    public class CustomPrincipalSerializeModel
    {
        public string Id { get; set; }
        public string Email { get; set; }
        public string Token { get; set; }
    }
}