using AutoMapper;
using getFood_API.Database;
using getFood_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace getFood_API.Services.Restoran
{
    public class KuhinjaServis : BaseCRUDService<MKuhinja, object, Database.Kuhinja,object,object>
    {
        public KuhinjaServis(getFoodContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}
