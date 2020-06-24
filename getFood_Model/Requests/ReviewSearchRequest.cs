using System;
using System.Collections.Generic;
using System.Text;

namespace getFood_Model.Requests
{
    public class ReviewSearchRequest
    {
        public int? RestoranId { get; set; }
        public int? ProduktId { get; set; }
        public string Ime { get; set; }
        public decimal? Ocjena { get; set; }
    }
}
