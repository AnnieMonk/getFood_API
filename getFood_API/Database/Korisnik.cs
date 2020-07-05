using System;
using System.Collections.Generic;

namespace getFood_API.Database
{
    public partial class Korisnik
    {
        public Korisnik()
        {
            Favoriti = new HashSet<Favoriti>();
            Izlaz = new HashSet<Izlaz>();
            Kartica = new HashSet<Kartica>();
            KorisnikRestoran = new HashSet<KorisnikRestoran>();
            KorisnikUloga = new HashSet<KorisnikUloga>();
            Kuponi = new HashSet<Kuponi>();
            Narudzba = new HashSet<Narudzba>();
            Review = new HashSet<Review>();
            Rezervacije = new HashSet<Rezervacije>();
        }

        public int KorisnikId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
        public string Adresa { get; set; }
        public string KorisnickoIme { get; set; }
        public string LozinkaHash { get; set; }
        public string LozinkaSalt { get; set; }
        public bool? Status { get; set; }

        public ICollection<Favoriti> Favoriti { get; set; }
        public ICollection<Izlaz> Izlaz { get; set; }
        public ICollection<Kartica> Kartica { get; set; }
        public ICollection<KorisnikRestoran> KorisnikRestoran { get; set; }
        public ICollection<KorisnikUloga> KorisnikUloga { get; set; }
        public ICollection<Kuponi> Kuponi { get; set; }
        public ICollection<Narudzba> Narudzba { get; set; }
        public ICollection<Review> Review { get; set; }
        public ICollection<Rezervacije> Rezervacije { get; set; }
    }
}
