using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using getFood_Model;
using getFood_Model.Requests;

namespace getFood_API.Services.Produkti
{
    public interface IProduktiServis
    {
        List<MProdukti> Get();
        MProdukti GetById(int id);
        MProdukti Insert(ProduktiUpsertRequest request);
        MProdukti Update(int id, ProduktiUpsertRequest request);
        MProdukti Delete(int id);

    }
}
