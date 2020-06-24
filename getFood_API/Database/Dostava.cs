using System;
using System.Collections.Generic;

namespace getFood_API.Database
{
    public partial class Dostava
    {
        public Dostava()
        {
            Narudzba = new HashSet<Narudzba>();
        }

        public int DostavaId { get; set; }
        public DateTime DatumVrijemeStart { get; set; }
        public DateTime DatumVrijemeEnd { get; set; }

        public ICollection<Narudzba> Narudzba { get; set; }
    }
}
