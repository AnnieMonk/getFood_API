using System;
using System.Collections.Generic;

namespace getFood_API.Database
{
    public partial class KorisnikUloga
    {
        public int KorisnikUlogaId { get; set; }
        public int UlogaId { get; set; }
        public int KorisnikId { get; set; }
        public DateTime DatumPromjene { get; set; }

        public Korisnik Korisnik { get; set; }
        public Uloga Uloga { get; set; }
    }
}
