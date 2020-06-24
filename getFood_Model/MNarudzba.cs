using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace getFood_Model
{
    public class MNarudzba
    {
        public int NarudzbaId { get; set; }
        public string BrojNarudzbe { get; set; }
        public DateTime Datum { get; set; }
        public string Napomena { get; set; }
        public int KorisnikId { get; set; }
        public int StatusId { get; set; }
        public int RestoranId { get; set; }
        public int? DostavaId { get; set; }
        public int? KuponId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Telefon { get; set; }
        public string RestoranNaziv { get; set; }
        public MDostava Dostava { get; set; }
        public MKorisnik Korisnik { get; set; }
        public MKuponi Kupon { get; set; }
        public MRestoran Restoran { get; set; }
        public MStatus Status { get; set; }
        public ICollection<MIzlaz> Izlaz { get; set; }
        public ICollection<MNarudzbaStavke> NarudzbaStavke { get; set; }
    }
}
