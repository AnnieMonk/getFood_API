using System;
using System.Collections.Generic;
using System.Text;

namespace getFood_Model.Requests
{
    public partial class KorisnikUpsertRequest
    {
        public string Ime { get; set; }
        public string KorisnickoIme { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
        public string Adresa { get; set; }
        public string Password { get; set; }
        public string PasswordConfirmation { get; set; }
        public List<int> Uloge { get; set; } = new List<int>();
        public int? GradId { get; set; }
        public int? KarticaId { get; set; }
       
    }
}
