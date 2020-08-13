using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interparking.DAL.Model
{
    public class TokenModel
    {
        public bool IsAuthenticated { get; set; }
        public string Token { get; set; }
        public string UserId { get; set; }
    }
}
