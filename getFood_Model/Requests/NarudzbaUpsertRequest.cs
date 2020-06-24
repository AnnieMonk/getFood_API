using System;
using System.Collections.Generic;
using System.Text;

namespace getFood_Model.Requests
{
    public class NarudzbaUpsertRequest
    {
        public int NarudzbaId { get; set; }
        public string BrojNarudzbe { get; set; }
        public DateTime Datum { get; set; }
        public string Napomena { get; set; }
        public int KorisnikId { get; set; }
        public int? DostavaId { get; set; }
        public int StatusId { get; set; }
        public int RestoranId { get; set; }
        public int? KuponId { get; set; }
        public List<int> Produkti { get; set; } = new List<int>();
        public List<int> Kolicine { get; set; } = new List<int>();

        // public Dostava DostavaNavigation { get; set; }

        // public ICollection<Dostava> Dostava { get; set; }
        // public ICollection<NarudzbaDodaci> NarudzbaDodaci { get; set; }
         public ICollection<MNarudzbaStavke> NarudzbaStavke { get; set; } 
    }
}
