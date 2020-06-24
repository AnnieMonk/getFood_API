using AutoMapper;
using getFood_API.Database;
using getFood_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace getFood_API.Services.Korisnik
{
    public class UlogaServis : BaseService<MUloga, object, Database.Uloga>
    {
        public UlogaServis(getFoodContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}
