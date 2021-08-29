using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace NtpProjekt
{
    public enum httpRijec
    {
        GET,
        POST,
        PUT,
        DELETE
    }

    class RestClient
    {
        public string krajnjaTocka { get; set; }
        public httpRijec httpMetoda { get; set; }

        public RestClient()
        {
            krajnjaTocka = string.Empty;
            httpMetoda = httpRijec.GET;
        }

        public string napraviZahtjev()
        {
            string strOdgovor = string.Empty;

            HttpWebRequest zahtjev = (HttpWebRequest)WebRequest.Create(krajnjaTocka);
            zahtjev.Method = httpMetoda.ToString();

            try
            {
                using (HttpWebResponse odgovor = (HttpWebResponse)zahtjev.GetResponse())
                {
                    if (odgovor.StatusCode != HttpStatusCode.OK)
                    {
                        throw new ApplicationException("Nešto nije u redu: " + odgovor.StatusCode.ToString());
                    }

                    using (Stream odgovorStream = odgovor.GetResponseStream())
                    {
                        if (odgovorStream != null)
                        {
                            using (StreamReader citacStream = new StreamReader(odgovorStream))
                            {
                                strOdgovor = citacStream.ReadToEnd();
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }

            return strOdgovor;
        }

    }
}
