using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NtpProjekt.Services
{
    public class DatabaseService
    {
        static protected KnjiznicaEntities obj = new KnjiznicaEntities();

        public static List<Knjige> SveKnjige()
        {
            return obj.Knjige.ToList();
        }
    }
}
