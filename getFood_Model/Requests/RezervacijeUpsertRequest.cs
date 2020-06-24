using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace getFood_Model.Requests
{
    public class RezervacijeUpsertRequest
    {
        [Required]
        public DateTime? DatumVrijeme { get; set; }
        public int KorisnikId { get; set; }
        public int RestoranId { get; set; }
        public string Napomena { get; set; }
        [Required]
        public int BrojLjudi { get; set; }
        public int StatusId { get; set; }
    }
}
