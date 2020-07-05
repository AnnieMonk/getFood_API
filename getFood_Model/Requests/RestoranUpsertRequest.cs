using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace getFood_Model.Requests
{
    public class RestoranUpsertRequest
    {
        [Required]
        public string Naziv { get; set; }
        [Required]
        public string Telefon { get; set; }
        [Required]
        public string Web { get; set; }
        [Required]
        public string Adresa { get; set; }
        [Required]
        public string RadnoVrijeme { get; set; }
        [Required(AllowEmptyStrings =false, ErrorMessage ="Unesite cijenu minimalne narudžbe")]
        public int MinimalnaNarudzba { get; set; }
        public string Opis { get; set; }
        [Required(ErrorMessage ="Niste unijeli kuhinju")]
        public int KuhinjaId { get; set; }
      
    }
}
