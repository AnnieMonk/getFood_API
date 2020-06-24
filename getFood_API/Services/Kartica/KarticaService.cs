using AutoMapper;
using getFood_API.Database;
using getFood_Model;
using getFood_Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace getFood_API.Services.Kartica
{
    public class KarticaService : BaseCRUDService<MKartica, KarticaSearchRequest, Database.Kartica, KarticaUpsertRequest, KarticaUpsertRequest>
    {
        public KarticaService(getFoodContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public override List<MKartica> Get(KarticaSearchRequest search)
        {
            var query = _context.Set<Database.Kartica>().AsQueryable();

            if(search.KorisnikID != null)
            {
                query = query.Where(i => i.KorisnikId == search.KorisnikID);
            }
            if(search.BrojKartice != null)
            {
                query = query.Where(i => i.BrojKartice == search.BrojKartice);
            }

            var list = query.ToList();


            return _mapper.Map<List<MKartica>>(list);
        }
    }
}
