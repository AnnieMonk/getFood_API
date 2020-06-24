using System;
using System.Collections.Generic;
using System.Text;

namespace getFood_Model.Requests
{
    public class KuponiUpsertRequest
    {
        public string Kod { get; set; }
        public decimal Popust { get; set; }
        public DateTime DatumIsteka { get; set; }
        public int? KorisnikId { get; set; }
    }
}
