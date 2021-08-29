using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace NtpProjekt
{
    class RestClient
    {
        public string krajnjaTocka { get; set; }
        public string httpMetoda { get; set; }

        public RestClient()
        {
            krajnjaTocka = "https://official-joke-api.appspot.com/random_joke";
            httpMetoda = "GET";
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
                                JObject json = JObject.Parse(citacStream.ReadToEnd().ToString()); 
                                strOdgovor = $"{json["setup"]}\n{json["punchline"]}";
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