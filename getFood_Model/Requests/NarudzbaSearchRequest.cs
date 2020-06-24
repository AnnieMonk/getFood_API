using System;
using System.Collections.Generic;
using System.Text;

namespace getFood_Model.Requests
{
    public class NarudzbaSearchRequest
    {
        public string BrojNarudzbe { get; set; }
        public DateTime? Datum { get; set; }
        public int? StatusID { get; set; }
        public int? RestoranID { get; set; }
        public int? NarudzbaID { get; set; }
        public int? KorisnikID { get; set; }
        public string Prezime { get; set; }
    }
}
