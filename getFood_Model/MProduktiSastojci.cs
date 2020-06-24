using System;
using System.Collections.Generic;
using System.Text;

namespace getFood_Model
{
    public class MProduktiSastojci
    {
        public int ProduktiSastojciId { get; set; }
        public decimal Kolicina { get; set; }
        public int SastojciId { get; set; }
        public int ProduktiId { get; set; }

        public string NazivProdukta { get; set; }
        public string NazivSastojka { get; set; }
        public decimal Cijena { get; set; }
        public string Opis { get; set; }
        //public virtual MProdukti Produkti { get; set; }
        //public virtual MSastojci Sastojci { get; set; }
    }
}
