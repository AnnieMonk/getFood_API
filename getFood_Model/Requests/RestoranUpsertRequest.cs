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
        [RegularExpression("^[+][(][0-9]{3}[)][0-9]{2}[/][0-9]{3}[-][0-9]{3}", ErrorMessage = "Broj telefona nije u tačnom formatu")]
        public string Telefon { get; set; }
        [Required]
        [RegularExpressionAttribute("^[w]{3}[.][a-z]{3,10}[.](com|ba|net)", ErrorMessage= "Web adresa nije u tačnom formatu")]
        public string Web { get; set; }
        [Required]
        public string Adresa { get; set; }
        [Required]
        [RegularExpression("^[0-9]{2}[:][0-9]{2}[-][0-9]{2}[:][0-9]{2}", ErrorMessage="Radno vrijeme nije u tačnom formatu")]
        public string RadnoVrijeme { get; set; }
        [Required(AllowEmptyStrings =false, ErrorMessage ="Unesite cijenu minimalne narudžbe")]
        public int MinimalnaNarudzba { get; set; }
        public string Opis { get; set; }
        [Required(ErrorMessage ="Niste unijeli kuhinju")]
        public int KuhinjaId { get; set; }
      
    }
}
