using getFood_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace getFood_API.Services.Sastojci
{
    public interface ISastojciServis
    {
        List<MSastojci> Get();
        MSastojci GetById(int id);

    }
}
