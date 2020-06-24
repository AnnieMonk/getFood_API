using System;
using System.Collections.Generic;
using System.Text;

namespace getFood_Model.Requests
{
    public class RezervacijaStolSearchRequest
    {
        public int? StolId { get; set; }
        public int? RezervacijaId { get; set; }
    }
}
