using System;
using System.Collections.Generic;
using System.Text;

namespace getFood_Model
{
    public class MFavoriti
    {
        public int FavoritId { get; set; }
        public int KorisnikId { get; set; }
        public int RestoranId { get; set; }

        public MKorisnik Korisnik { get; set; }
        public MRestoran Restoran { get; set; }
    }
}
