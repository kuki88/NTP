using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace NtpProjekt
{
    class EnkripcijaSHA
    {
        public string Enkriptiraj(string podaci)
        {
            SHA256 sh = SHA256.Create();
            byte[] hashPodaci = sh.ComputeHash(Encoding.Default.GetBytes(podaci));
            StringBuilder str = new StringBuilder();

            for (int i = 0; i < hashPodaci.Length; i++)
            {
                str.Append(hashPodaci[i].ToString());
            }

            return str.ToString();
        }
    }
}
