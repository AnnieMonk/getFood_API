using System;
using System.Collections.Generic;
using System.Text;

namespace getFood_Model
{
    public class MRestoran
    {
        public int RestoranId { get; set; }
        public string Naziv { get; set; }
        public string Telefon { get; set; }
        public string Web { get; set; }
        public string Adresa { get; set; }
        public string RadnoVrijeme { get; set; }
        public decimal? Rating { get; set; }
        public int MinimalnaNarudzba { get; set; }
        public bool FreeDostava { get; set; }
       
        public string Opis { get; set; }
        public int KuhinjaId { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
        public decimal? CijenaDostave { get; set; }

        public string KuhinjaNaziv { get; set; }
        public MKuhinja Kuhinja { get; set; }
        public ICollection<MKorisnikRestoran> KorisnikRestoran { get; set; }
        public ICollection<MMeni> Meni { get; set; }
       // public ICollection<MNarudzba> Narudzba { get; set; }
        public ICollection<MReview> Review { get; set; }
        public ICollection<MRezervacije> Rezervacije { get; set; }
    }
}
