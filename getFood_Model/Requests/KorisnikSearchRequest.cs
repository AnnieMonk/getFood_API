using System;
using System.Collections.Generic;
using System.Text;

namespace getFood_Model.Requests
{
    public class KorisnikSearchRequest
    {
        public int? KorisnikId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string KorisnickoIme { get; set; }

       
    }
}
