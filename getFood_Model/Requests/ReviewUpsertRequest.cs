using System;
using System.Collections.Generic;
using System.Text;

namespace getFood_Model.Requests
{
    public class ReviewUpsertRequest
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Komentar { get; set; }
        public decimal Ocjena { get; set; }
        public int? RestoranId { get; set; }
        public int? ProduktiId { get; set; }
        public int KorisnikId { get; set; }
        public DateTime? Datum { get; set; }

    }
}
