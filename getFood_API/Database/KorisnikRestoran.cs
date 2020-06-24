using System;
using System.Collections.Generic;

namespace getFood_API.Database
{
    public partial class KorisnikRestoran
    {
        public int KorisnikRestoranId { get; set; }
        public int KorisnikId { get; set; }
        public int RestoranId { get; set; }

        public Korisnik Korisnik { get; set; }
        public Restoran Restoran { get; set; }
    }
}
