using System;
using System.Security.Cryptography;
using System.Text;

namespace Interparking.Users.Api.Infrastructure.Security
{
    public static class Protector
    {
        public static string GetSalt()
        {
            var rng = RandomNumberGenerator.Create();
            var saltBytes = new byte[16];
            rng.GetBytes(saltBytes);
            return Convert.ToBase64String(saltBytes);
        }

        public static string SaltAndHashPassword(string password, string salt)
        {
            var sha = SHA256.Create();
            var saltedPassword = password + salt;
            return Convert.ToBase64String(sha.ComputeHash( Encoding.Unicode.GetBytes(saltedPassword)));
        }
    }
}
