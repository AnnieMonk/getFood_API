using System;
using System.Collections.Generic;
using System.Text;

namespace getFood_Model
{
    public partial class MKorisnikUloga
    {
        public int KorisnikUlogaId { get; set; }
        public int KorisnikId { get; set; }
        public int UlogaId { get; set; }
        public DateTime DatumIzmjene { get; set; }

        //public MKorisnik Korisnik { get; set; }
        public MUloga Uloga { get; set; }
    }
}
