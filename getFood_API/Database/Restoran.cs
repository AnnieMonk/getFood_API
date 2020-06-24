using System;
using System.Collections.Generic;

namespace getFood_API.Database
{
    public partial class Restoran
    {
        public Restoran()
        {
            Favoriti = new HashSet<Favoriti>();
            KorisnikRestoran = new HashSet<KorisnikRestoran>();
            Meni = new HashSet<Meni>();
            Narudzba = new HashSet<Narudzba>();
            Review = new HashSet<Review>();
            Rezervacije = new HashSet<Rezervacije>();
        }

        public int RestoranId { get; set; }
        public string Naziv { get; set; }
        public string Telefon { get; set; }
        public string Web { get; set; }
        public string Adresa { get; set; }
        public string RadnoVrijeme { get; set; }
        public int MinimalnaNarudzba { get; set; }
        public string Opis { get; set; }
        public int KuhinjaId { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
        public decimal? Rating { get; set; }

        public Kuhinja Kuhinja { get; set; }
        public ICollection<Favoriti> Favoriti { get; set; }
        public ICollection<KorisnikRestoran> KorisnikRestoran { get; set; }
        public ICollection<Meni> Meni { get; set; }
        public ICollection<Narudzba> Narudzba { get; set; }
        public ICollection<Review> Review { get; set; }
        public ICollection<Rezervacije> Rezervacije { get; set; }
    }
}
