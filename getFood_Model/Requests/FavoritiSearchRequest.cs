using System;
using System.Collections.Generic;
using System.Text;

namespace getFood_Model.Requests
{
    public class FavoritiSearchRequest
    {
        public int? FavoritId { get; set; }
        public int? KorisnikId { get; set; }
        public int? RestoranId { get; set; }
        public int? KuhinjaId { get; set; }
    }
}
