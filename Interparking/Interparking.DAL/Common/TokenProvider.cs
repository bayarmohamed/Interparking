using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Security;

namespace Interparking.DAL.Common
{
    public class TokenProvider : ITokenProvider
    {
       

        public string CurrentToken
        {
            get
            {
                var authcookie = HttpCookie;

                if (authcookie != null)
                    return ExtractTokenFromHttpCookie(authcookie);

                if (IsTokenPresentInQueryString())
                    return ExtractTokenFromQueryString();

                return ExtractTokenFromRequestForm();
            }
        }

        private static HttpCookie HttpCookie => HttpContext.Current.Request.Cookies[FormsAuthentication.FormsCookieName];

        private static string ExtractTokenFromHttpCookie(HttpCookie cookie)
        {
            FormsAuthenticationTicket ticket = FormsAuthentication.Decrypt(cookie.Value);

            if (ticket is null)
            {
               
                return string.Empty;
            }

            if (string.IsNullOrWhiteSpace(ticket.UserData))
            {
                
                return string.Empty;
            }

            var token = ticket.UserData.Split(':')[1];

            if (string.IsNullOrWhiteSpace(token))
            {
               
                return string.Empty;
            }

            return token;
        }

        private static bool IsTokenPresentInQueryString() => !string.IsNullOrWhiteSpace(HttpContext.Current.Request.QueryString.Get("token"));

        private static string ExtractTokenFromQueryString() => HttpContext.Current.Request.QueryString.Get("token");

        private static string ExtractTokenFromRequestForm() => HttpContext.Current.Request.Form.Get("Token");
    }
}