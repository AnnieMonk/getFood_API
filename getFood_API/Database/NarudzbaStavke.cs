using System;
using System.Collections.Generic;

namespace getFood_API.Database
{
    public partial class NarudzbaStavke
    {
        public int NarudzbaStavkeId { get; set; }
        public int Kolicina { get; set; }
        public int NarudzbaId { get; set; }
        public int ProduktiId { get; set; }

        public Narudzba Narudzba { get; set; }
        public Produkti Produkti { get; set; }
    }
}
