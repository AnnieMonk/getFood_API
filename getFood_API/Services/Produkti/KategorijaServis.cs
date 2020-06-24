using AutoMapper;
using getFood_API.Database;
using getFood_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace getFood_API.Services
{
    public class KategorijaServis : BaseCRUDService<MKategorija, object, Database.Kategorija, object, object>
    {
        public KategorijaServis(getFoodContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}
