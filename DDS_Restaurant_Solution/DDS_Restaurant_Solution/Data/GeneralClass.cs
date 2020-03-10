using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace DDS_Restaurant_Solution.Data
{
    public class GeneralClass
    {
        public static int IdUsuario { get; set; }
        public static string SHA1(string text)
        {
            var data = Encoding.ASCII.GetBytes(text);
            var hashData = new SHA1Managed().ComputeHash(data);
            var hash = string.Empty;

            foreach (var b in hashData)
            {
                hash += b.ToString("X2");
            }

            return hash.ToLower();
        }
    }
}
