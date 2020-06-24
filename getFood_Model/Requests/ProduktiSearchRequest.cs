using System;
using System.Collections.Generic;
using System.Text;

namespace getFood_Model.Requests
{
    public class ProduktiSearchRequest
    {
        public int? ProduktiId { get; set; }
        public int? KategorijaId { get; set; }
        public int? RestoranId { get; set; }
        public int? MeniId { get; set; }
    
        public string Naziv { get; set; }
    }
}
