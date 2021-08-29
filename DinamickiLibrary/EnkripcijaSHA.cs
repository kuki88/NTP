using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DinamickiLibrary
{
    public class EnkripcijaSHA
    {
        public string dekriptiraniPodatak { get; set; }
        public string enkriptiraniPodatak { get; set; }

        public void Enkriptiraj()
        {
            SHA256 sh = SHA256.Create();
            byte[] hashPodaci = sh.ComputeHash(Encoding.Default.GetBytes(dekriptiraniPodatak));
            StringBuilder str = new StringBuilder();

            for (int i = 0; i < hashPodaci.Length; i++)
            {
                str.Append(hashPodaci[i].ToString());
            }

            enkriptiraniPodatak = str.ToString();
        }
        public string Dekriptiraj()
        {
            return "Teško je dekriptirati SHA algoritam :)";
        }
    }
}
