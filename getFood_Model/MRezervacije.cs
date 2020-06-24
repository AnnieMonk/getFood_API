using System;
using System.Collections.Generic;
using System.Text;

namespace getFood_Model
{
    public class MRezervacije
    {
        public int RezervacijaId { get; set; }
        public string Napomena { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime DatumVrijeme { get; set; }
        public int BrojLjudi { get; set; }
        public int KorisnikId { get; set; }
        public int RestoranId { get; set; }
        public int StatusId { get; set; }
        public string Status { get; set; }
        public string Restoran { get; set; }

    }
}
