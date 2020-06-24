using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace getFood_Model.Requests
{
    public partial class ProduktiUpsertRequest
    {
        [Required]
        public string Naziv { get; set; }
        [Required]
        public decimal Cijena { get; set; }
        [Required]
        public string Opis { get; set; }
        [Required]
        public byte[] Slika { get; set; }
        public byte[] SlikaThumb { get; set; }
        [Required]
        public List<int> Sastojci { get; set; } = new List<int>();
        [Required]
        public List<int> Meni { get; set; } = new List<int>();

        [Required]
        public int KategorijaId { get; set; }
    }
}
