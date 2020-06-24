using System;
using System.Collections.Generic;
using System.Text;

namespace getFood_Model.Requests
{
    public class IzlazStavkeUpsertRequest
    {
        public int Kolicina { get; set; }
        public decimal Cijena { get; set; }
        public decimal? Popust { get; set; }
        public int IzlazId { get; set; }
        public int ProduktiId { get; set; }
    }
}
