using System;
using System.Collections.Generic;
using System.Text;

namespace getFood_Model.Requests
{
    public class MeniSearchRequest
    {
        public int? MeniId { get; set; }
        public int? RestoranId { get; set; }
        public string Naziv { get; set; }
    }
}
