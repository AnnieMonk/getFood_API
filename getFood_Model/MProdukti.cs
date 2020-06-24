using System;
using System.Collections.Generic;
using System.Text;

namespace getFood_Model
{
    public class MProdukti
    {
        public int ProduktiId { get; set; }
        public string Naziv { get; set; }
        public decimal? Rating { get; set; }
        public decimal Cijena { get; set; }
        public string Opis { get; set; }
        public byte[] Slika { get; set; }
        public byte[] SlikaThumb { get; set; }
        public int KategorijaId { get; set; }

      

        public MKategorija Kategorija { get; set; }
        public ICollection<MMeniProdukti> MeniProdukti { get; set; }

        public ICollection<MProduktiSastojci> ProduktiSastojci { get; set; } 
    }
}
