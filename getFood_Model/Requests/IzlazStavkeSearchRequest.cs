using System;
using System.Collections.Generic;
using System.Text;

namespace getFood_Model.Requests
{
    public class IzlazStavkeSearchRequest
    {
        public DateTime? Od { get; set; }
        public DateTime? Do { get; set; }
        public string TacanDatum { get; set; }

        public int RestoranId { get; set; }
        public string godina { get; set; }

        public string BrojRacuna { get; set; }
    }
}
