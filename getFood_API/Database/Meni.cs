using System;
using System.Collections.Generic;

namespace getFood_API.Database
{
    public partial class Meni
    {
        public Meni()
        {
            MeniProdukti = new HashSet<MeniProdukti>();
        }

        public int MeniId { get; set; }
        public string Naziv { get; set; }
        public DateTime DatumNapravljen { get; set; }
        public DateTime? DatumIsteka { get; set; }
        public string Opis { get; set; }
        public int RestoranId { get; set; }

        public Restoran Restoran { get; set; }
        public ICollection<MeniProdukti> MeniProdukti { get; set; }
    }
}
