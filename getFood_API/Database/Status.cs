using System;
using System.Collections.Generic;

namespace getFood_API.Database
{
    public partial class Status
    {
        public Status()
        {
            Kuponi = new HashSet<Kuponi>();
            Narudzba = new HashSet<Narudzba>();
            Rezervacije = new HashSet<Rezervacije>();
        }

        public int StatusId { get; set; }
        public string Naziv { get; set; }

        public ICollection<Kuponi> Kuponi { get; set; }
        public ICollection<Narudzba> Narudzba { get; set; }
        public ICollection<Rezervacije> Rezervacije { get; set; }
    }
}
