using System;
using System.Collections.Generic;

namespace getFood_API.Database
{
    public partial class Kuhinja
    {
        public Kuhinja()
        {
            Restoran = new HashSet<Restoran>();
        }

        public int KuhinjaId { get; set; }
        public string Naziv { get; set; }

        public ICollection<Restoran> Restoran { get; set; }
    }
}
