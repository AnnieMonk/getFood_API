using AutoMapper;
using getFood_API.Database;
using getFood_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace getFood_API.Services.Korisnik
{
    public class KorisnikUlogaServis : BaseService<MKorisnikUloga, object, Database.KorisnikUloga>
    {
        public KorisnikUlogaServis(getFoodContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public override List<MKorisnikUloga> Get(object search)
        {
            var list = _context.KorisnikUloga.ToList();

            return _mapper.Map<List<MKorisnikUloga>>(list);
        }
    }
}
