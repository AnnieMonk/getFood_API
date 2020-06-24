using System;
using System.Collections.Generic;

namespace getFood_API.Database
{
    public partial class Narudzba
    {
        public Narudzba()
        {
            Izlaz = new HashSet<Izlaz>();
            NarudzbaStavke = new HashSet<NarudzbaStavke>();
        }

        public int NarudzbaId { get; set; }
        public string BrojNarudzbe { get; set; }
        public DateTime Datum { get; set; }
        public string Napomena { get; set; }
        public int KorisnikId { get; set; }
        public int StatusId { get; set; }
        public int RestoranId { get; set; }
        public int? DostavaId { get; set; }
        public int? KuponId { get; set; }

        public Dostava Dostava { get; set; }
        public Korisnik Korisnik { get; set; }
        public Kuponi Kupon { get; set; }
        public Restoran Restoran { get; set; }
        public Status Status { get; set; }
        public ICollection<Izlaz> Izlaz { get; set; }
        public ICollection<NarudzbaStavke> NarudzbaStavke { get; set; }
    }
}
