using System;
using System.Collections.Generic;
using System.Text;

namespace getFood_Model
{
    public class MKuponi
    {
        public int KuponId { get; set; }
        public string Kod { get; set; }
        public decimal Popust { get; set; }
        public DateTime DatumIsteka { get; set; }
        public int? KorisnikId { get; set; }
        public int StatusId { get; set; }
        public string Status { get; set; }
        public MKorisnik Korisnik { get; set; }
    }
}
