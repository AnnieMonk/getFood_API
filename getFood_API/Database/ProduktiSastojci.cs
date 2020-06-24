using System;
using System.Collections.Generic;

namespace getFood_API.Database
{
    public partial class ProduktiSastojci
    {
        public int ProduktiSastojciId { get; set; }
        public decimal Kolicina { get; set; }
        public int SastojciId { get; set; }
        public int ProduktiId { get; set; }

        public Produkti Produkti { get; set; }
        public Sastojci Sastojci { get; set; }
    }
}
