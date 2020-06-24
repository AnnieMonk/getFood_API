using System;
using System.Collections.Generic;

namespace getFood_API.Database
{
    public partial class IzlazStavke
    {
        public int IzlazStavkeId { get; set; }
        public int Kolicina { get; set; }
        public decimal Cijena { get; set; }
        public decimal? Popust { get; set; }
        public int IzlazId { get; set; }
        public int ProduktiId { get; set; }

        public Izlaz Izlaz { get; set; }
        public Produkti Produkti { get; set; }
    }
}
