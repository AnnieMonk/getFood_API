using System;
using System.Collections.Generic;
using System.Text;

namespace getFood_Model
{
    public class MIzlazStavke
    {
        public int IzlazStavkeId { get; set; }
        public int Kolicina { get; set; }
        public decimal Cijena { get; set; }
        public decimal? Popust { get; set; }
        public string BrojRacuna { get; set; }
        public DateTime Datum { get; set; }
        public decimal IznosBezPdv { get; set; }
        public decimal IznosSaPdv { get; set; }

        public string Naziv { get; set; }
        public string Opis { get; set; }
        public int IzlazId { get; set; }
        public int ProduktiId { get; set; }

    }
}
