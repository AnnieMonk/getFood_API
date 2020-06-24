using System;
using System.Collections.Generic;

namespace getFood_API.Database
{
    public partial class MeniProdukti
    {
        public int MeniProduktiId { get; set; }
        public int ProduktiId { get; set; }
        public int MeniId { get; set; }

        public Meni Meni { get; set; }
        public Produkti Produkti { get; set; }
    }
}
