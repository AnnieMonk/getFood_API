using getFood_Model;
using getFood_Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace getFood_API.Services
{
    public interface IKorisnikServis
    {
        List<MKorisnik> GetKorisnici(KorisnikSearchRequest request);
        MKorisnik GetById(int id);

        MKorisnik Insert(KorisnikUpsertRequest request);
        MKorisnik Update(int id, KorisnikUpsertRequest request);


        Task<MKorisnik> Authenticate(string username, string pass);
       

    }
}
