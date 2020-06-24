using AutoMapper;
using getFood_API.Database;
using getFood_Model;
using getFood_Model.Requests;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace getFood_API.Services.NarudzbaStavke
{
    public class NarudzbaStavkeService : BaseCRUDService<MNarudzbaStavke, NarudzbaStavkeSearchRequest, Database.NarudzbaStavke, NarudzbaStavkeUpsertRequest, NarudzbaStavkeUpsertRequest>
    {
        public NarudzbaStavkeService(getFoodContext context, IMapper mapper) : base(context, mapper)
        {
        }
        public override List<MNarudzbaStavke> Get(NarudzbaStavkeSearchRequest search)
        {
            var query = _context.Set<Database.NarudzbaStavke>().AsQueryable();

            if (search.NarudzbaId != null)
                query = query.Where(i => i.Narudzba.NarudzbaId == search.NarudzbaId);
            if (search.RestoranId != null)
                query = query.Where(i => i.Narudzba.Restoran.RestoranId == search.RestoranId);
            if (search.BrojNarudzbe != null)
                query = query.Where(i => i.Narudzba.BrojNarudzbe == search.BrojNarudzbe);
            if (search.KorisnikId != null)
                query = query.Where(i => i.Narudzba.KorisnikId == search.KorisnikId);

            var list = query
                .Include(i=>i.Narudzba)
                .Include(i=>i.Narudzba.Korisnik)
                .Include(i=>i.Narudzba.Kupon)
                .Include(i=>i.Produkti)
                .Select(i => new MNarudzbaStavke
                {
                    Cijena = i.Produkti.Cijena,
                    Naziv = i.Produkti.Naziv,
                    Opis = i.Produkti.Opis,
                    Kolicina = i.Kolicina,
                    NarudzbaId = i.NarudzbaId,
                    ProduktiId = i.ProduktiId,
                    NarudzbaStavkeId=i.NarudzbaStavkeId,
                    KorisnikId = i.Narudzba.Korisnik.KorisnikId,
                    KuponId = i.Narudzba.Kupon.KuponId,
                    Datum=i.Narudzba.Datum,
                    Popust = (double)i.Narudzba.Kupon.Popust
                }).ToList();

            return _mapper.Map<List<MNarudzbaStavke>>(list);
        }
    }
}
