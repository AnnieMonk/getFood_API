using AutoMapper;
using getFood_API.Database;
using getFood_Model;
using getFood_Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace getFood_API.Services.Favoriti
{
    public class FavoritiService : BaseCRUDService<MFavoriti, FavoritiSearchRequest, Database.Favoriti, FavoritiUpsertRequest, FavoritiUpsertRequest>
    {
        public FavoritiService(getFoodContext context, IMapper mapper) : base(context, mapper)
        {
        }
        public override List<MFavoriti> Get(FavoritiSearchRequest search)
        {
            var query = _context.Set<Database.Favoriti>().AsQueryable();

            if(search.KorisnikId != null)
            {
                query = query.Where(i => i.KorisnikId == search.KorisnikId);
            }
            if (search.KuhinjaId != null)
            {
                query = query.Where(i => i.Restoran.KuhinjaId == search.KuhinjaId);
            }
            if (search.RestoranId != null)
            {
                query = query.Where(i => i.RestoranId == search.RestoranId);
            }
            var list = query.ToList();


            return _mapper.Map<List<MFavoriti>>(list);
        }
     
    }
}
