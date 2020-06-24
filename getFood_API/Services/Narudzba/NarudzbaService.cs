using AutoMapper;
using getFood_API.Database;
using getFood_Model;
using getFood_Model.Requests;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace getFood_API.Services.Narudzba
{
    public class NarudzbaService : BaseCRUDService<MNarudzba, NarudzbaSearchRequest, Database.Narudzba, NarudzbaUpsertRequest, NarudzbaUpsertRequest>
    {
        public NarudzbaService(getFoodContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public override List<MNarudzba> Get(NarudzbaSearchRequest search)
        {
            var query = _context.Set<Database.Narudzba>().AsQueryable();

            if(search.StatusID != null)
            {
                query = query.Where(i => i.StatusId == search.StatusID);
            }
            if (search.RestoranID != null)
            {
                query = query.Where(i => i.RestoranId == search.RestoranID);
            }
            if (search.NarudzbaID != null)
            {
                query = query.Where(i => i.NarudzbaId == search.NarudzbaID);
            }
            if(search.Datum != null)
            {
                query = query.Where(i => i.Datum.Date == search.Datum.Value.Date);
            }
            if (search.KorisnikID != null)
            {
                query = query.Where(i => i.KorisnikId == search.KorisnikID);
            }
            if(search.Prezime != null)
            {
                query = query.Where(i => i.Korisnik.Prezime == search.Prezime);
            }


            var list = query
                .Include(i=>i.Korisnik)
                .Select(i => new MNarudzba
                {
                    BrojNarudzbe = i.BrojNarudzbe,
                    Datum = i.Datum,
                    DostavaId = i.DostavaId,
                    Ime = i.Korisnik.Ime,
                    Prezime = i.Korisnik.Prezime,
                    KorisnikId = i.KorisnikId,
                    Napomena = i.Napomena,
                    NarudzbaId = i.NarudzbaId,
                    RestoranId = i.RestoranId,
                    StatusId = i.StatusId,
                    Telefon=i.Korisnik.Telefon,
                    KuponId=i.KuponId,
                    RestoranNaziv = i.Restoran.Naziv
                   

                }).OrderByDescending(i=>i.BrojNarudzbe).ToList();

            return _mapper.Map<List<MNarudzba>>(list);
        }

        public override MNarudzba GetById(int id)
        {
            var query = _context.Narudzba.Include(i => i.Korisnik).Where(i => i.NarudzbaId == id).FirstOrDefault();

            var result = new MNarudzba
            {
                BrojNarudzbe = query.BrojNarudzbe,
                Datum = query.Datum,
                DostavaId = query.DostavaId,
                Ime = query.Korisnik.Ime,
                Prezime = query.Korisnik.Prezime,
                KorisnikId = query.KorisnikId,
                Napomena = query.Napomena,
                NarudzbaId = query.NarudzbaId,
                RestoranId = query.RestoranId,
                StatusId = query.StatusId,
                Telefon = query.Korisnik.Telefon,
                KuponId=query.KuponId
            };

            return _mapper.Map<MNarudzba>(result);
        }
        public override MNarudzba Insert(NarudzbaUpsertRequest request)
        {
            var entity = _mapper.Map<Database.Narudzba>(request);

            _context.Set<Database.Narudzba>().Add(entity);
            _context.SaveChanges();

            if(request.Produkti.Count() == request.Kolicine.Count()) 
            { 
           
                for(int i=0; i< request.Produkti.Count(); i++)
                {
                    var NarudzbaStavke = new Database.NarudzbaStavke();
                    NarudzbaStavke.ProduktiId = request.Produkti[i];
                    NarudzbaStavke.NarudzbaId = entity.NarudzbaId;
                    NarudzbaStavke.Kolicina = request.Kolicine[i];
               
                    _context.Set<Database.NarudzbaStavke>().Add(NarudzbaStavke);
                }
                _context.SaveChanges();
                
            }
            if(request.KuponId != null)
            {
                var kupon = _context.Kuponi.Where(i => i.KuponId == entity.KuponId).FirstOrDefault();
                kupon.StatusId = _context.Status.Where(i => i.Naziv == "Iskorišten").Select(i => i.StatusId).FirstOrDefault();
                _context.SaveChanges();
            }

           
           

            return _mapper.Map<MNarudzba>(entity);
        }

        public override MNarudzba Update(int id, NarudzbaUpsertRequest request)
        {
            var entity = _context.Narudzba.Find(id);
            _mapper.Map(request, entity);
            _context.SaveChanges();

            if (request.Produkti.Count() == request.Kolicine.Count())
            {

                for (int i = 0; i < request.Produkti.Count(); i++)
                {
                    var NarudzbaStavke = _context.NarudzbaStavke.Find(id);
                    NarudzbaStavke.ProduktiId = request.Produkti[i];
                    NarudzbaStavke.NarudzbaId = entity.NarudzbaId;
                    NarudzbaStavke.Kolicina = request.Kolicine[i];

                    // _context.Set<Database.NarudzbaStavke>().Add(NarudzbaStavke);
                    _context.SaveChanges();
                }
               

            }
            if (request.KuponId != null)
            {
                var kupon = _context.Kuponi.Where(i => i.KuponId == entity.KuponId).FirstOrDefault();
                kupon.StatusId = _context.Status.Where(i => i.Naziv == "Iskorišten").Select(i => i.StatusId).FirstOrDefault();
                _context.SaveChanges();
            }

            return _mapper.Map<MNarudzba>(entity);


        }
    }
}
