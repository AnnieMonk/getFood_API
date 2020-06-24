using System;
using System.Collections.Generic;

namespace getFood_API.Database
{
    public partial class Uloga
    {
        public Uloga()
        {
            KorisnikUloga = new HashSet<KorisnikUloga>();
        }

        public int UlogaId { get; set; }
        public string Naziv { get; set; }
        public string Opis { get; set; }

        public ICollection<KorisnikUloga> KorisnikUloga { get; set; }
    }
}
