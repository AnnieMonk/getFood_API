using System;
using System.Collections.Generic;

namespace getFood_API.Database
{
    public partial class Rezervacije
    {
        public int RezervacijaId { get; set; }
        public DateTime DatumVrijeme { get; set; }
        public int BrojLjudi { get; set; }
        public int KorisnikId { get; set; }
        public int RestoranId { get; set; }
        public int StatusId { get; set; }
        public string Napomena { get; set; }

        public Korisnik Korisnik { get; set; }
        public Restoran Restoran { get; set; }
        public Status Status { get; set; }
    }
}
