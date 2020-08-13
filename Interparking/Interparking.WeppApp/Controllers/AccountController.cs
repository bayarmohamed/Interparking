using Interparking.DAL.Abstraction;
using Interparking.WeppApp.Infrastructure.Principal;
using Interparking.WeppApp.Models.Account;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using System.Web.Security;

namespace Interparking.WeppApp.Controllers
{
    public class AccountController : Controller
    {
        IUserRepository userRepository;

        public AccountController(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }
        // GET: Account
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [Obsolete]
        public ActionResult Login(Credential credential)
        {
            

            var user = userRepository.GetToekn(new DAL.Model.CredentialModel
            {
                email = credential.Email.Trim(),
                password = credential.Password
            }).Result;

            if (user.IsAuthenticated)
            {
                CustomPrincipalSerializeModel serializeModel = new CustomPrincipalSerializeModel();
                serializeModel.Id = user.UserId;
                serializeModel.Email = credential.Email;
                serializeModel.Token = user.Token;

                JavaScriptSerializer serializer = new JavaScriptSerializer();

                string userData = serializer.Serialize(serializeModel);
                FormsAuthenticationTicket authTicket = new FormsAuthenticationTicket(
                     1,
                     credential.Email,
                     DateTime.Now,
                     DateTime.Now.AddMinutes(15),
                     false,
                     userData);
                string encTicket = FormsAuthentication.Encrypt(authTicket);
                HttpCookie faCookie = new HttpCookie(FormsAuthentication.FormsCookieName, encTicket);
                Response.Cookies.Add(faCookie);

                Decrypt(faCookie);
                //var cookie = GetAuthenticationCookie(credential.Email, user.Token);
                return View("~/Views/Home/Index.cshtml");
            }
            else
            {
                return View();
            }



           
        }

        private void Decrypt(HttpCookie authCookie)
        {

            FormsAuthenticationTicket authTicket = FormsAuthentication.Decrypt(authCookie.Value);

            JavaScriptSerializer serializer = new JavaScriptSerializer();

            CustomPrincipalSerializeModel serializeModel = serializer.Deserialize<CustomPrincipalSerializeModel>(authTicket.UserData);

            CustomPrincipal newUser = new CustomPrincipal(authTicket.Name);
            newUser.Id = serializeModel.Id;
            newUser.Email = serializeModel.Email;
            newUser.Token = serializeModel.Token;

            HttpContext.User = newUser;



        }

        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();

            return View("~/Views/Account/Login.cshtml");
        }
      
        private HttpCookie GetAuthenticationCookie(string email, string token)
        {
            var cookie = FormsAuthentication.GetAuthCookie(email, true);

            var ticket = FormsAuthentication.Decrypt(cookie.Value);

            var userData = $"{email}:{token}";

            var newTicket = new FormsAuthenticationTicket(ticket.Version, ticket.Name, ticket.IssueDate, ticket.Expiration, true, userData);

            var encTicket = FormsAuthentication.Encrypt(newTicket);

            return new HttpCookie(FormsAuthentication.FormsCookieName, encTicket) { HttpOnly = true };
        }

    }
}