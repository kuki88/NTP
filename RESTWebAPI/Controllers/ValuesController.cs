using NtpProjekt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RESTWebAPI.Controllers
{
    [Authorize]
    //[Route("api/[controller]")]
    public class ValuesController : ApiController
    {
        KnjiznicaEntities obj = new KnjiznicaEntities();

        public Knjige GetKnjigaByISBN(string isbn)
        {
            return obj.Knjige.Where(x => x.ISBN == isbn).FirstOrDefault();
        }
        [HttpPost]
        public void SpremiKnjigu([FromBody]Knjige knjiga)
        {
            obj.Knjige.Add(knjiga);
            obj.SaveChanges();
        }

    }
}
