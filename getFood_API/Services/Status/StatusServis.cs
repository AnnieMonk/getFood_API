using AutoMapper;
using getFood_API.Database;
using getFood_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace getFood_API.Services.Status
{
    public class StatusServis : BaseService<MStatus, object, Database.Status>
    {
        public StatusServis(getFoodContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}
