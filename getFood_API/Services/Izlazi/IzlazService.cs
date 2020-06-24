using AutoMapper;
using getFood_API.Database;
using getFood_Model;
using getFood_Model.Requests;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace getFood_API.Services.Izlazi
{
    public class IzlazService : BaseCRUDService<MIzlaz, IzlazSearchRequest, Database.Izlaz, IzlazUpsertRequest, IzlazUpsertRequest>
    {
        public IzlazService(getFoodContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public override List<MIzlaz> Get(IzlazSearchRequest search)
        {
            var query = _context.Set<Database.Izlaz>().AsQueryable();

            if (search.KorisnikId != null)
                query = query.Where(i => i.KorisnikId == search.KorisnikId);

            var list = query.ToList();

            return _mapper.Map<List<MIzlaz>>(list);
        }
        public override MIzlaz Insert(IzlazUpsertRequest request)
        {
            var entity = _mapper.Map<Database.Izlaz>(request);

            _context.Set<Database.Izlaz>().Add(entity);
            _context.SaveChanges();

            var narudzbaStavke = _context.NarudzbaStavke
                .Include(i=>i.Produkti)
                .Include(i=>i.Narudzba)
                .Include(i=>i.Narudzba.Kupon)
                .Where(i => i.NarudzbaId == request.NarudzbaId).ToList();

            foreach(var x in narudzbaStavke)
            {
                IzlazStavke izlazStavke = new Database.IzlazStavke();
                izlazStavke.ProduktiId = x.ProduktiId;
                izlazStavke.Kolicina = x.Kolicina;
                
                if (x.Narudzba.KuponId != null)
                {
                    izlazStavke.Popust = x.Narudzba.Kupon.Popust;
                    var cijenaSaPopustom = (x.Produkti.Cijena * x.Kolicina) - (x.Produkti.Cijena * x.Kolicina) * (x.Narudzba.Kupon.Popust / 100);
                    izlazStavke.Cijena = cijenaSaPopustom;
                }
                    
                else
                {
                    izlazStavke.Popust = 0;
                }
                    
                izlazStavke.IzlazId = entity.IzlazId;

                _context.Set<Database.IzlazStavke>().Add(izlazStavke);
            }
            _context.SaveChanges();
            
            var narudzba = _context.Narudzba.Find(request.NarudzbaId);
            narudzba.StatusId = 2; 
            _context.SaveChanges();

            return _mapper.Map<MIzlaz>(entity);
        }
    }
}
