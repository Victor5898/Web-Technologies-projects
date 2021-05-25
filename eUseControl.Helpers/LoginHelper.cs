using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace eUseControl.Helpers
{
    public class LoginHelper
    {
        public static string HashGen(string password)
        {
            MD5 md5alg = new MD5CryptoServiceProvider();
            var originPass = Encoding.Default.GetBytes(password + "randomString");
            var encodedPass = md5alg.ComputeHash(originPass);

            return BitConverter.ToString(encodedPass).Replace("-", "").ToLower();
        }
    }
}
