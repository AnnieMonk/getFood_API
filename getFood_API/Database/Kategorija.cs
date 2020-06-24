using System;
using System.Collections.Generic;

namespace getFood_API.Database
{
    public partial class Kategorija
    {
        public Kategorija()
        {
            Produkti = new HashSet<Produkti>();
        }

        public int KategorijaId { get; set; }
        public string Naziv { get; set; }

        public ICollection<Produkti> Produkti { get; set; }
    }
}
