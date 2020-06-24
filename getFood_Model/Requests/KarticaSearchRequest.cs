using System;
using System.Collections.Generic;
using System.Text;

namespace getFood_Model.Requests
{
    public class KarticaSearchRequest
    {
        public int? KorisnikID { get; set; }
        public long? BrojKartice { get; set; }
    }
}
