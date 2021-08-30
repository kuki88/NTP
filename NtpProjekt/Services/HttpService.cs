using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NtpProjekt.Services
{
    public class HttpService
    {
        public async static void DodajKnjigu(string knjiga)
        {
            HttpContent httpContent = new StringContent(knjiga);

            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:1562/api/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

                var response = await client.PostAsJsonAsync("Values/SpremiKnjigu", knjiga);

                MessageBox.Show(response.ToString());


                //try
                //{
                //    using (HttpResponseMessage response = await client.PostAsync("http://localhost:1562/api/ValuesController/SpremiKnjigu", httpContent))
                //    {
                //        using (HttpContent cont = response.Content)
                //        {
                //            HttpContentHeaders headers = cont.Headers;
                //            MessageBox.Show(headers.ToString());
                //        }
                //    }
                //}
                //catch (Exception ex)
                //{
                //    MessageBox.Show(ex.Message);
                //}
            }
        }

        //public async static Knjige TraziKnjigu(string isbn)
        //{
        //    Knjige odgovor;
        //    HttpContent content = new StringContent(isbn);

        //    using (HttpClient client = new HttpClient())
        //    {
        //        client.BaseAddress = new Uri("http://localhost:1562/api/");
        //        client.DefaultRequestHeaders.Accept.Clear();
        //        client.DefaultRequestHeaders.Accept.Add(
        //        new MediaTypeWithQualityHeaderValue("application/json"));

        //        odgovor = await client.GetAsync("Values/GetKnjigaByISBN");
        //    }

        //    return odgovor;
        //}
    }
}
