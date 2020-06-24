using AutoMapper;
using getFood_API.Database;
using getFood_Model;
using getFood_Model.Requests;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace getFood_API.Services.Izlazi
{
    public class IzlazStavkeService : BaseCRUDService<MIzlazStavke, IzlazStavkeSearchRequest, Database.IzlazStavke, IzlazStavkeUpsertRequest, IzlazStavkeUpsertRequest>
    {
        public IzlazStavkeService(getFoodContext context, IMapper mapper) : base(context, mapper)
        {
        }
        public override List<MIzlazStavke> Get(IzlazStavkeSearchRequest search)
        {
            var query = _context.Set<Database.IzlazStavke>().AsQueryable();

            if(search.Od != null)
            {
                query = query.Where(i => i.Izlaz.Datum >= search.Od);
            }
            if(search.Do != null)
            {
                query = query.Where(i => i.Izlaz.Datum <= search.Do);

            }
            if(search.TacanDatum != null)
            {
                
                query = query.Where(i => i.Izlaz.Datum.Date.ToString("dd/MM/yyy") == search.TacanDatum);
            }
            if(search.godina != null)
            {
               
                query = query.Where(i => i.Izlaz.Datum.Year.ToString() == search.godina);
            }
            if(search.BrojRacuna != null)
            {
                query = query.Where(i => i.Izlaz.BrojRacuna == search.BrojRacuna);
            }
            query = query.Where(i => i.Izlaz.Narudzba.Restoran.RestoranId == search.RestoranId);


            var list = query
                .Include(i=>i.Izlaz)
                .Include(i=>i.Produkti)
                .Select(i => new MIzlazStavke
            {
                BrojRacuna = i.Izlaz.BrojRacuna,
                Cijena = i.Cijena,
                Datum = i.Izlaz.Datum,
                IznosBezPdv = i.Izlaz.IznosBezPdv,
                IznosSaPdv = i.Izlaz.IznosSaPdv,
                Kolicina = i.Kolicina,
                Opis = i.Produkti.Opis,
                Naziv = i.Produkti.Naziv,
                Popust = i.Popust,
                IzlazId = i.IzlazId,
                IzlazStavkeId = i.IzlazStavkeId,
                ProduktiId = i.ProduktiId
            }).ToList();

            return _mapper.Map<List<MIzlazStavke>>(list);
        }
    }
}
