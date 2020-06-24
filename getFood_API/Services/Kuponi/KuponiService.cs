using AutoMapper;
using getFood_API.Database;
using getFood_Model;
using getFood_Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace getFood_API.Services.Kuponi
{
    public class KuponiService : BaseCRUDService<MKuponi, KuponiSearchRequest, Database.Kuponi, KuponiUpsertRequest, KuponiUpsertRequest>
    {
        public KuponiService(getFoodContext context, IMapper mapper) : base(context, mapper)
        {
        }
        public override List<MKuponi> Get(KuponiSearchRequest search)
        {
            var query = _context.Set<Database.Kuponi>().AsQueryable();

            if(search.KorisnikId != null)
            {
                query = query.Where(i => i.KorisnikId == search.KorisnikId);
            }
            if(search.Status != null)
            {
                query = query.Where(i => i.Status.Naziv == search.Status);
            }

            var list = query
                .Select(i => new MKuponi
                {
                    DatumIsteka=i.DatumIsteka,
                    Kod=i.Kod,
                    KorisnikId=i.KorisnikId,
                    KuponId=i.KuponId,
                    Popust=i.Popust,
                    StatusId=i.StatusId,
                    Status=i.Status.Naziv

                }).ToList();

           

            return _mapper.Map<List<MKuponi>>(list);
        }
    }
}
