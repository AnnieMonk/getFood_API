using System;
using System.Collections.Generic;

namespace getFood_API.Database
{
    public partial class Sastojci
    {
        public Sastojci()
        {
            ProduktiSastojci = new HashSet<ProduktiSastojci>();
        }

        public int SastojciId { get; set; }
        public string Naziv { get; set; }

        public ICollection<ProduktiSastojci> ProduktiSastojci { get; set; }
    }
}
