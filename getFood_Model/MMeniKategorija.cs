using System;
using System.Collections.Generic;
using System.Text;

namespace getFood_Model
{
    public class MMeniKategorija
    {
        public int MeniKategorijaId { get; set; }
        public int BrojKategorija { get; set; }
        public int KategorijaId { get; set; }
        public int MeniId { get; set; }

        public virtual MKategorija Kategorija { get; set; }
        public virtual MMeniProdukti Meni { get; set; }
    }
}
