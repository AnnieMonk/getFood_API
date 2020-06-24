using AutoMapper;
using getFood_API.Database;
using getFood_Model;
using getFood_Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace getFood_API.Services.Meni
{
    public class MeniServis : BaseCRUDService<MMeni, MeniSearchRequest, Database.Meni, MeniUpsertRequest, MeniUpsertRequest>
    {
        public MeniServis(getFoodContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public override List<MMeni> Get(MeniSearchRequest search)
        {
            var query = _context.Set<Database.Meni>().AsQueryable();

            if(search?.RestoranId != null)
            {
                query = query.Where(i => i.RestoranId == search.RestoranId);
            }
            var list = query.ToList();

            return _mapper.Map<List<MMeni>>(list);
        }
        public override MMeni Insert(MeniUpsertRequest request)
        {
            var entity = _mapper.Map<Database.Meni>(request);

            _context.Set<Database.Meni>().Add(entity);
            _context.SaveChanges();

            foreach (var proizvodi in request.listaProizvoda)
            {

                var produkti = new Database.MeniProdukti();

                produkti.ProduktiId = proizvodi;
                produkti.MeniId = entity.MeniId;

                _context.Set<Database.MeniProdukti>().Add(produkti);
            }
            _context.SaveChanges();

            return _mapper.Map<MMeni>(entity);
        }
        public override MMeni Update(int id, MeniUpsertRequest request)
        {
            var entity = _context.Meni.Find(id);

            _mapper.Map(request, entity);
            _context.SaveChanges();

            var lista = _context.MeniProdukti.Where(i => i.MeniId == id).Select(j => j.ProduktiId).ToList(); //meni sa svim produktima
            var zaObrisati = lista.Except(request.listaProizvoda);

            //ako je uradjen uncheck
            foreach (var x in zaObrisati)
            {
                if (lista.Contains(x))
                {
                    var produkt = _context.MeniProdukti.Where(i => i.ProduktiId == x).ToList();
                    foreach (var y in produkt)
                    {
                        _context.Set<Database.MeniProdukti>().Remove(y);
                    }

                }
            }

            //ako su dodani dodatni
            foreach (var j in request.listaProizvoda)
            {
                if (!lista.Contains(j))
                {
                    //ako nije isti produkt onda
                    var produkti = new Database.MeniProdukti();

                    produkti.ProduktiId = j;
                    produkti.MeniId = entity.MeniId;

                    _context.Set<Database.MeniProdukti>().Add(produkti);
                }
                //obrisati iz meniProdukti one koji se nalaze u listu a ne nalaze u requestu
                //check if lista exists in request
               
                
            }
            _context.SaveChanges();
           

            return _mapper.Map<MMeni>(entity);
        }

        public override bool Delete(int id)
        {
            if (id != 0)
            {
            //    //moras prvo obrisati produktiSastoji
            //    var produktiSastojci = _context.ProduktiSastojci.Where(i => i.ProduktiId == id).ToList();

            //    foreach (var x in produktiSastojci)
            //    {
            //        _context.Remove(x);
            //    }
            //    _context.SaveChanges();

                var meniProdukti = _context.MeniProdukti.Where(i => i.MeniId == id).ToList();

                foreach (var x in meniProdukti)
                {
                    _context.Remove(x);
                }
                _context.SaveChanges();

                var meni = _context.Meni.Find(id);

                _context.Remove(meni);

                _context.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
