using getFood_Model;
using getFood_API.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using getFood_Model.Requests;
using AutoMapper;

namespace getFood_API.Services.Sastojci
{
    public class SastojciServis : BaseCRUDService<MSastojci, SastojciSearchRequest, Database.Sastojci, SastojciUpsertRequest, SastojciUpsertRequest>
    {
        public SastojciServis(getFoodContext context, IMapper mapper) : base(context, mapper)
        {
        }
        public override List<MSastojci> Get(SastojciSearchRequest search)
        {
            var query = _context.Set<Database.Sastojci>().AsQueryable();

            if (!string.IsNullOrWhiteSpace(search?.Naziv))
            {
                query = query.Where(x => x.Naziv == search.Naziv);
            }

            //query = query.OrderBy(x => x.Naziv);

            var list = query.ToList();

            return _mapper.Map<List<MSastojci>>(list);
        }
    }
}
