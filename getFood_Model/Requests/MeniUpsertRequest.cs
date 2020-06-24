using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace getFood_Model.Requests
{
    public class MeniUpsertRequest
    {
        [Required]
        public string Naziv { get; set; }
        [Required]
        public DateTime DatumNapravljen { get; set; }
        [Required]
        public DateTime? DatumIsteka { get; set; }
        public string Opis { get; set; }
        public int RestoranId { get; set; }
        [Required]
        public List<int> listaProizvoda { get; set; } = new List<int>();

    }
}
