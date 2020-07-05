using AutoMapper;
using getFood_API.Database;
using getFood_Model;
using getFood_Model.Requests;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace getFood_API.Services.Restoran
{
    public class RestoranServis : BaseCRUDService<MRestoran, RestoranSearchRequest, Database.Restoran, RestoranUpsertRequest, RestoranUpsertRequest>
    {
        public RestoranServis(getFoodContext context, IMapper mapper) : base(context, mapper)
        {
        }
        public override List<MRestoran> Get(RestoranSearchRequest search)
        {
            var query = _context.Set<Database.Restoran>().AsQueryable();

            if(search?.KuhinjaId != null)
            {
                query = query.Where(i => i.KuhinjaId == search.KuhinjaId);
            }
            if(search.MinimalnaNarudzba != null)
            {
                query = query.Where(i => i.MinimalnaNarudzba <= search.MinimalnaNarudzba);
            }
            

            var result = query
                .Include(i => i.Kuhinja)
               
                .Select(i => new MRestoran
                {
                    Naziv= i.Naziv,
                    Adresa=i.Adresa,
                    KuhinjaId=i.KuhinjaId,
                    KuhinjaNaziv=i.Kuhinja.Naziv,
                    MinimalnaNarudzba=i.MinimalnaNarudzba,
                    Opis=i.Opis,
                    RadnoVrijeme=i.RadnoVrijeme,
                    Rating=i.Rating,
                    Telefon=i.Telefon,
                    Web=i.Web,
                    RestoranId=i.RestoranId,
                    Latitude=i.Latitude,
                    Longitude=i.Longitude
                }).ToList();

            return _mapper.Map<List<MRestoran>>(result);
        }
       

    }
}
