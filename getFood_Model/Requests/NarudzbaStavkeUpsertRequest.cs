using System;
using System.Collections.Generic;
using System.Text;

namespace getFood_Model.Requests
{
    public class NarudzbaStavkeUpsertRequest
    {
        public int NarudzbaStavkeId { get; set; }
        public int Kolicina { get; set; }
        public int NarudzbaId { get; set; }
        public int ProduktiId { get; set; }
    }
}
