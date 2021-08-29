using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DinamickiLibrary
{
    public class EnkripcijaRSA
    {
        UnicodeEncoding byteConverter = new UnicodeEncoding();
        public string podatakZaKriptiranje { get; set; }
        public byte[] enkriptiraniPodatak { get; set; }
        public string dekriptiraniPodatak { get; set; }

        public void RSAEnkripcija(RSAParameters parametarKey, bool OAEPP)
        {
            try
            {
                using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider())
                {
                    rsa.ImportParameters(parametarKey);
                    enkriptiraniPodatak = rsa.Encrypt(byteConverter.GetBytes(podatakZaKriptiranje), OAEPP);
                }
            }
            catch (CryptographicException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void RSADekripcija(RSAParameters parametarKey, bool OAEPP)
        {
            try
            {
                using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider())
                {
                    rsa.ImportParameters(parametarKey);
                    dekriptiraniPodatak = byteConverter.GetString(rsa.Decrypt(enkriptiraniPodatak, OAEPP));
                }
            }
            catch (CryptographicException e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
