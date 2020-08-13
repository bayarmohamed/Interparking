using Interparking.WeppApp.Models.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Interparking.WeppApp.Command
{
    public class CreateUserCommand:ICommand<bool>
    {
        public string name { get; set; }
        public string email { get; set; }
        public string password { get; set; }

    }
}