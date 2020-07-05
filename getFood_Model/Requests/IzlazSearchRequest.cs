using System;
using System.Collections.Generic;
using System.Text;

namespace getFood_Model.Requests
{
    public class IzlazSearchRequest
    {
        public string BrojRacuna { get; set; }
        public int? NarudzbaId { get; set; }
        public int? RestoranId { get; set; }
        public int? KorisnikId { get; set; }
        public DateTime? Datum { get; set; }
    }
}
