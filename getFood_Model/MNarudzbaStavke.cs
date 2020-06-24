using System;
using System.Collections.Generic;
using System.Text;

namespace getFood_Model
{
    public class MNarudzbaStavke
    {
        public int NarudzbaStavkeId { get; set; }
        public int Kolicina { get; set; }
        public int NarudzbaId { get; set; }
        public int ProduktiId { get; set; }
        public int KorisnikId { get; set; }
        public int? KuponId { get; set; }

        public DateTime Datum { get; set; }

        public double? Popust { get; set; }

        public string Naziv { get; set; }
        public string Opis { get; set; }
        public decimal Cijena { get; set; }

     
        //  public MNarudzba Narudzba { get; set; }
        // public MProdukti Produkti { get; set; }
    }
}
