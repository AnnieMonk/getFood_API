using System;
using System.Collections.Generic;

namespace getFood_API.Database
{
    public partial class Kartica
    {
        public int KarticaId { get; set; }
        public long BrojKartice { get; set; }
        public int SecurityCode { get; set; }
        public int ExpMonth { get; set; }
        public int ExpYear { get; set; }
        public int KorisnikId { get; set; }

        public Korisnik Korisnik { get; set; }
    }
}
