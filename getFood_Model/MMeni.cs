using System;
using System.Collections.Generic;
using System.Text;

namespace getFood_Model
{
    public class MMeni
    {
        public int MeniId { get; set; }
        public string Naziv { get; set; }
        public DateTime DatumNapravljen { get; set; }
        public DateTime? DatumIsteka { get; set; }
        public string Opis { get; set; }
        public int RestoranId { get; set; }

        public MRestoran Restoran { get; set; }
        public ICollection<MMeniProdukti> MeniProdukti { get; set; }
    }
}
