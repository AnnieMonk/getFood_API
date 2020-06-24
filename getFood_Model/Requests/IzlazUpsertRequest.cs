using System;
using System.Collections.Generic;
using System.Text;

namespace getFood_Model.Requests
{
    public class IzlazUpsertRequest
    {
        public string BrojRacuna { get; set; }
        public DateTime Datum { get; set; }
        public decimal IznosBezPdv { get; set; }
        public decimal IznosSaPdv { get; set; }
        public int NarudzbaId { get; set; }
       
        public int KorisnikId { get; set; }

    }
}
