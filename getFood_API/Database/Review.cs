using System;
using System.Collections.Generic;

namespace getFood_API.Database
{
    public partial class Review
    {
        public int ReviewId { get; set; }
        public DateTime Datum { get; set; }
        public decimal Ocjena { get; set; }
        public string Komentar { get; set; }
        public int KorisnikId { get; set; }
        public int? RestoranId { get; set; }
        public int? ProduktiId { get; set; }

        public Korisnik Korisnik { get; set; }
        public Produkti Produkti { get; set; }
        public Restoran Restoran { get; set; }
    }
}
