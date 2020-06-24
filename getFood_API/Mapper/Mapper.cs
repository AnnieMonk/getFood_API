using AutoMapper;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace getFood_API.Mapper
{
    public class Mapper : Profile
    {
        public Mapper()
        {
            CreateMap<Database.Korisnik, getFood_Model.MKorisnik>().ReverseMap();
            CreateMap<Database.KorisnikUloga, getFood_Model.MKorisnikUloga>().ReverseMap();
            CreateMap<Database.Uloga, getFood_Model.MUloga>().ReverseMap();
            CreateMap<Database.Sastojci, getFood_Model.MSastojci>().ReverseMap();
            CreateMap<Database.Produkti, getFood_Model.MProdukti>().ReverseMap();
            CreateMap<Database.Kategorija, getFood_Model.MKategorija>().ReverseMap();
            CreateMap<Database.Restoran, getFood_Model.MRestoran>().ReverseMap();
            CreateMap<Database.Kuhinja, getFood_Model.MKuhinja>().ReverseMap();
            CreateMap<Database.Review, getFood_Model.MReview>().ReverseMap();
            CreateMap<Database.ProduktiSastojci, getFood_Model.MProduktiSastojci>().ReverseMap();
            CreateMap<Database.MeniProdukti, getFood_Model.MMeniProdukti>().ReverseMap();
            CreateMap<Database.Meni, getFood_Model.MMeni>().ReverseMap();
            CreateMap<Database.Rezervacije, getFood_Model.MRezervacije>().ReverseMap();
            CreateMap<Database.KorisnikRestoran, getFood_Model.MKorisnikRestoran>().ReverseMap();
            CreateMap<Database.Narudzba, getFood_Model.MNarudzba>().ReverseMap();
            CreateMap<Database.NarudzbaStavke, getFood_Model.MNarudzbaStavke>().ReverseMap();
            CreateMap<Database.Dostava, getFood_Model.MDostava>().ReverseMap();            
            CreateMap<Database.Status, getFood_Model.MStatus>().ReverseMap();
            CreateMap<Database.Kartica, getFood_Model.MKartica>().ReverseMap();
            CreateMap<Database.Izlaz, getFood_Model.MIzlaz>().ReverseMap();
            CreateMap<Database.IzlazStavke, getFood_Model.MIzlazStavke>().ReverseMap();
            CreateMap<Database.Favoriti, getFood_Model.MFavoriti>().ReverseMap();
            CreateMap<Database.Kuponi, getFood_Model.MKuponi>().ReverseMap();
            
            //CreateMap<Database.ProduktiSastojci, Int32>().ReverseMap();
            CreateMap<getFood_Model.MProdukti, getFood_Model.MProduktiSastojci>().ReverseMap();
            
           

            CreateMap<Database.Korisnik, getFood_Model.Requests.KorisnikUpsertRequest>().ReverseMap();
            CreateMap<Database.Korisnik, getFood_Model.Requests.KorisnikSearchRequest>().ReverseMap();
            CreateMap<Database.Produkti, getFood_Model.Requests.ProduktiUpsertRequest>().ReverseMap();
            CreateMap<Database.Restoran, getFood_Model.Requests.RestoranUpsertRequest>().ReverseMap();
            CreateMap<Database.ProduktiSastojci, getFood_Model.Requests.ProduktiSastojciSearchRequest>().ReverseMap();
            CreateMap<Database.MeniProdukti, getFood_Model.Requests.MeniProduktiSearchRequest>().ReverseMap();
            CreateMap<Database.Sastojci, getFood_Model.Requests.SastojciUpsertRequest>().ReverseMap();
            CreateMap<Database.Meni, getFood_Model.Requests.MeniUpsertRequest>().ReverseMap();
            CreateMap<Database.Review, getFood_Model.Requests.ReviewUpsertRequest>().ReverseMap();
            CreateMap<Database.Review, getFood_Model.Requests.ReviewSearchRequest>().ReverseMap();
            CreateMap<Database.Rezervacije, getFood_Model.Requests.RezervacijeUpsertRequest>().ReverseMap();
            CreateMap<Database.Narudzba, getFood_Model.Requests.NarudzbaUpsertRequest>().ReverseMap();
            CreateMap<Database.Narudzba, getFood_Model.Requests.NarudzbaSearchRequest>().ReverseMap();
            CreateMap<Database.NarudzbaStavke, getFood_Model.Requests.NarudzbaStavkeSearchRequest>().ReverseMap();
            CreateMap<Database.NarudzbaStavke, getFood_Model.Requests.NarudzbaStavkeUpsertRequest>().ReverseMap();
            CreateMap<Database.Dostava, getFood_Model.Requests.DostavaSearchRequest>().ReverseMap();
            CreateMap<Database.Dostava, getFood_Model.Requests.DostavaUpsertRequest>().ReverseMap();
            CreateMap<Database.Kartica, getFood_Model.Requests.KarticaUpsertRequest>().ReverseMap();
            CreateMap<Database.Kartica, getFood_Model.Requests.KarticaSearchRequest>().ReverseMap();
            CreateMap<Database.Izlaz, getFood_Model.Requests.IzlazUpsertRequest>().ReverseMap();
            CreateMap<Database.Izlaz, getFood_Model.Requests.IzlazSearchRequest>().ReverseMap();
            CreateMap<Database.IzlazStavke, getFood_Model.Requests.IzlazStavkeUpsertRequest>().ReverseMap();
            CreateMap<Database.Favoriti, getFood_Model.Requests.FavoritiUpsertRequest>().ReverseMap();
            CreateMap<Database.Favoriti, getFood_Model.Requests.FavoritiSearchRequest>().ReverseMap();
            CreateMap<Database.Kuponi, getFood_Model.Requests.KuponiUpsertRequest>().ReverseMap();
            CreateMap<Database.Kuponi, getFood_Model.Requests.KuponiSearchRequest>().ReverseMap();
            
           
            








        }

    }
}
