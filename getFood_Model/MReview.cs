using System;
using System.Collections.Generic;
using System.Text;

namespace getFood_Model
{
    public class MReview
    {
        public int ReviewId { get; set; }
        public DateTime Datum { get; set; }
        public decimal Ocjena { get; set; }
        public string Komentar { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string KorisnickoIme { get; set; }
        public int KorisnikId { get; set; }
        public int? RestoranId { get; set; }
        public int? ProduktiId { get; set; }
    }
}
