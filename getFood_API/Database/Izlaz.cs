using System;
using System.Collections.Generic;

namespace getFood_API.Database
{
    public partial class Izlaz
    {
        public Izlaz()
        {
            IzlazStavke = new HashSet<IzlazStavke>();
        }

        public int IzlazId { get; set; }
        public string BrojRacuna { get; set; }
        public DateTime Datum { get; set; }
        public decimal IznosBezPdv { get; set; }
        public decimal IznosSaPdv { get; set; }
        public int NarudzbaId { get; set; }
        public int KorisnikId { get; set; }

        public Korisnik Korisnik { get; set; }
        public Narudzba Narudzba { get; set; }
        public ICollection<IzlazStavke> IzlazStavke { get; set; }
    }
}
