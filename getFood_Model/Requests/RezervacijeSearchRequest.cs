using System;
using System.Collections.Generic;
using System.Text;

namespace getFood_Model.Requests
{
    public class RezervacijeSearchRequest
    {
        public int? RezervacijaId { get; set; }
        public int? KorisnikId { get; set; }
        public int? RestoranId { get; set; }
        public int? StatusId { get; set; }
        public string Ime { get; set; }
        public DateTime? DatumVrijeme { get; set; }
        public bool? samoBuduce { get; set; }

    }
}
