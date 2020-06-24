using AutoMapper;
using getFood_API.Database;
using getFood_Model;
using getFood_Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace getFood_API.Services.KorisnikRestoran
{
    public class KorisnikRestoranService : BaseService<MKorisnikRestoran, KorisnikRestoranSearchRequest, Database.KorisnikRestoran>
    {
        public KorisnikRestoranService(getFoodContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public override List<MKorisnikRestoran> Get(KorisnikRestoranSearchRequest search)
        {
            var query = _context.Set<Database.KorisnikRestoran>().AsQueryable();
            if(search.KorisnikId != null)
            {
                query = query.Where(i => i.KorisnikId == search.KorisnikId);
            }
            var list = query.ToList();

            return _mapper.Map<List<MKorisnikRestoran>>(list);
        }
    }
}
