using System;
using System.Collections.Generic;
using System.Text;

namespace getFood_Model
{
    public partial class MKorisnik
    {
        public int KorisnikId { get; set; }
        public string KorisnickoIme { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
        public string Adresa { get; set; }
        public bool? Status { get; set; }
        public string FullName
        {
            get
            {
                return Ime + " " + Prezime;
            }
        }

        public ICollection<MKorisnikUloga> KorisnikUloga { get; set; }
    }
}
