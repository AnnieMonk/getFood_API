using System;
using System.Collections.Generic;
using System.Text;

namespace getFood_Model.Requests
{
    public class KuponiSearchRequest
    {
        public string Kod { get; set; }
        public DateTime? DatumIsteka { get; set; }
        public int? KorisnikId { get; set; }
        public string Status { get; set; }
    }
}
