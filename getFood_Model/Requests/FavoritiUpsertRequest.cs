using System;
using System.Collections.Generic;
using System.Text;

namespace getFood_Model.Requests
{
    public class FavoritiUpsertRequest
    {
        public int KorisnikId { get; set; }
        public int RestoranId { get; set; }

    }
}
