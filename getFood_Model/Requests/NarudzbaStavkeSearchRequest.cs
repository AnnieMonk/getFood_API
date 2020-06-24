using System;
using System.Collections.Generic;
using System.Text;

namespace getFood_Model.Requests
{
    public class NarudzbaStavkeSearchRequest
    {
        public int? NarudzbaId { get; set; }
        public int? RestoranId { get; set; }
        public string BrojNarudzbe { get; set; }
        public int? KorisnikId { get; set; }
    }
}
