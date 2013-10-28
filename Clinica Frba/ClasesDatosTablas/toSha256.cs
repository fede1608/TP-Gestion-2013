using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;


namespace Clinica_Frba.ClasesDatosTablas
{
    public static class toSha256
    {
        public static string ToSha256(this string someString)
        {
            var bytes = Encoding.UTF8.GetBytes(someString);
            var hashstring = new SHA256Managed();
            var hash = hashstring.ComputeHash(bytes);

            return hash.Aggregate(string.Empty, (current, x) => current + string.Format("{0:x2}", x));
        }
    }
}
