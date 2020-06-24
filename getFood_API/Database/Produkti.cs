using System;
using System.Collections.Generic;

namespace getFood_API.Database
{
    public partial class Produkti
    {
        public Produkti()
        {
            IzlazStavke = new HashSet<IzlazStavke>();
            MeniProdukti = new HashSet<MeniProdukti>();
            NarudzbaStavke = new HashSet<NarudzbaStavke>();
            ProduktiSastojci = new HashSet<ProduktiSastojci>();
            Review = new HashSet<Review>();
        }

        public int ProduktiId { get; set; }
        public string Naziv { get; set; }
        public decimal Cijena { get; set; }
        public string Opis { get; set; }
        public byte[] Slika { get; set; }
        public byte[] SlikaThumb { get; set; }
        public int KategorijaId { get; set; }
        public decimal? Rating { get; set; }

        public Kategorija Kategorija { get; set; }
        public ICollection<IzlazStavke> IzlazStavke { get; set; }
        public ICollection<MeniProdukti> MeniProdukti { get; set; }
        public ICollection<NarudzbaStavke> NarudzbaStavke { get; set; }
        public ICollection<ProduktiSastojci> ProduktiSastojci { get; set; }
        public ICollection<Review> Review { get; set; }
    }
}
