using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Interparking.WeppApp.Models.Account
{
    public class Credential
    {
        [Required(ErrorMessage ="Email required")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Password required")]
        public string Password { get; set; }
    }
}