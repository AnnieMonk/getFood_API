using System;
using System.Collections.Generic;

namespace getFood_API.Database
{
    public partial class Kuponi
    {
        public Kuponi()
        {
            Narudzba = new HashSet<Narudzba>();
        }

        public int KuponId { get; set; }
        public string Kod { get; set; }
        public decimal Popust { get; set; }
        public DateTime DatumIsteka { get; set; }
        public int? KorisnikId { get; set; }
        public int StatusId { get; set; }

        public Korisnik Korisnik { get; set; }
        public Status Status { get; set; }
        public ICollection<Narudzba> Narudzba { get; set; }
    }
}
