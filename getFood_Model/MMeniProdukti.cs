using System;
using System.Collections.Generic;
using System.Text;

namespace getFood_Model
{
    public class MMeniProdukti
    {
        public int MeniProduktiId { get; set; }
        public int ProduktiId { get; set; }
        public int MeniId { get; set; }
        public int KategorijaId { get; set; }
        public int RestoranId { get; set; }
        
        public string Naziv { get; set; } //misli se na naziv produkta
        public string NazivMenija { get; set; }
        public string Opis { get; set; }
        public decimal Cijena { get; set; }
       
        public byte[] SlikaThumb { get; set; }
        public decimal? Rating { get; set; }

        public List<MProduktiSastojci> sastojciList = new List<MProduktiSastojci>();

        public MProdukti Produkt { get; set; }

    }
}
