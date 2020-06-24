using System;
using System.Collections.Generic;
using System.Text;

namespace getFood_Model.Requests
{
    public class StolSearchRequest
    {
        public int? StolId { get; set; }
        public int? RezervacijaId { get; set; }
        public string Oznaka { get; set; }
    }
}
