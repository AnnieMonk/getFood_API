using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using getFood_Model;
using getFood_Model.Requests;
using getFood_API.Database;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace getFood_API.Services.Rezervacije
{
    public class RezervacijeServis : BaseCRUDService<MRezervacije, RezervacijeSearchRequest, Database.Rezervacije, RezervacijeUpsertRequest, RezervacijeUpsertRequest>
    {
        public RezervacijeServis(getFoodContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public override List<MRezervacije> Get(RezervacijeSearchRequest search)
        {

            var query = _context.Set<Database.Rezervacije>().AsQueryable();
            

            if (search?.Ime != null)
            {
                query = query.Include(i => i.Korisnik).Where(x => x.Korisnik.Ime == search.Ime);
            }
            if (search?.DatumVrijeme != null)
            {
                query = query.Where(x => x.DatumVrijeme == search.DatumVrijeme);
            }
            else if(search.samoBuduce != null)
            {
                query = query.Where(x => x.DatumVrijeme > DateTime.Now);
            }
            if(search.RestoranId != null)
            {
                query = query.Where(x => x.RestoranId == search.RestoranId);
            }
            if(search.KorisnikId != null)
            {
                query = query.Where(x => x.Korisnik.KorisnikId == search.KorisnikId);
            }
            if (search.StatusId != null)
            {
                query = query.Where(x => x.StatusId == search.StatusId);
            }
            

            var result = query
                .Include(i => i.Korisnik)
                .Select(j => new MRezervacije
                {

                    BrojLjudi = j.BrojLjudi,
                    Ime = j.Korisnik.Ime,
                    Prezime=j.Korisnik.Prezime,
                    DatumVrijeme = j.DatumVrijeme,
                    KorisnikId = j.KorisnikId,
                    RestoranId = j.RestoranId,
                    StatusId = j.StatusId,
                    RezervacijaId = j.RezervacijaId,
                    Status = j.Status.Naziv,
                    Napomena= j.Napomena,
                    Restoran = j.Restoran.Naziv
                    
                    
                   
                }).OrderByDescending(i=>i.DatumVrijeme).ToList();

            

            return _mapper.Map < List <MRezervacije>>(result);
        }
     

    }
}
