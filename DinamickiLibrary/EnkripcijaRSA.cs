using NtpProjekt;
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
                Globals.RSA.ImportParameters(parametarKey);
                enkriptiraniPodatak = Globals.RSA.Encrypt(byteConverter.GetBytes(podatakZaKriptiranje), OAEPP);
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
                Globals.RSA.ImportParameters(parametarKey);
                var aa = Globals.RSA.Decrypt(enkriptiraniPodatak, OAEPP);
                dekriptiraniPodatak = byteConverter.GetString(aa);
            }
            catch (CryptographicException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
