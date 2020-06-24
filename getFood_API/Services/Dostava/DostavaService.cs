using AutoMapper;
using getFood_API.Database;
using getFood_Model;
using getFood_Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace getFood_API.Services.Dostava
{
    public class DostavaService : BaseCRUDService<MDostava, DostavaSearchRequest, Database.Dostava, DostavaUpsertRequest, DostavaUpsertRequest>
    {
        public DostavaService(getFoodContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public override MDostava Insert(DostavaUpsertRequest request)
        {
            var entity = _mapper.Map<Database.Dostava>(request);
          
           
            _context.Set<Database.Dostava>().Add(entity);
            _context.SaveChanges();

            return _mapper.Map<MDostava>(entity);
        }

        public override MDostava Update(int id, DostavaUpsertRequest request)
        {
            var entity = _context.Dostava.Find(id);

            
            _mapper.Map(request, entity);
            _context.SaveChanges();

            return _mapper.Map<MDostava>(entity);
        }
    }
}
