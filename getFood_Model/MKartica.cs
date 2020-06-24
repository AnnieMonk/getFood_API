using System;
using System.Collections.Generic;
using System.Text;

namespace getFood_Model
{
    public class MKartica
    {
        public int KarticaId { get; set; }
        public long BrojKartice { get; set; }
        public int SecurityCode { get; set; }
        public int ExpMonth { get; set; }
        public int ExpYear { get; set; }
        public int KorisnikId { get; set; }
    }
}
