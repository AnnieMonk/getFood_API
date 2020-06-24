using AutoMapper;
using getFood_API.Database;
using getFood_Model;
using getFood_Model.Requests;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace getFood_API.Services.MeniProdukti
{
    public class MeniProduktiServis : BaseService<MMeniProdukti, MeniProduktiSearchRequest, Database.MeniProdukti>
    {
        public MeniProduktiServis(getFoodContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public override List<MMeniProdukti> Get(MeniProduktiSearchRequest search)
        {
            var query = _context.Set<Database.MeniProdukti>().AsQueryable();

            if (search?.ProduktiId.HasValue == true)
            {
                query = query.Where(x => x.ProduktiId == search.ProduktiId);
            }
            if (search?.KategorijaId.HasValue == true )
            {
                query = query.Where(x => x.Produkti.Kategorija.KategorijaId == search.KategorijaId);
            }
            if (search?.MeniId.HasValue == true )
            {
                query = query.Where(x => x.MeniId == search.MeniId);
            }
            if (search?.RestoranId.HasValue == true)
            {
                query = query.Include(i => i.Meni).Where(x => x.Meni.RestoranId == search.RestoranId );
            }
            if(search.Naziv != null)
            {
                query = query.Where(i => i.Produkti.Naziv == search.Naziv);
            }

            var result = query
                .Include(i => i.Meni)
                .Include(i => i.Produkti)
                .Include(i => i.Produkti.Kategorija)
                .Select(i => new MMeniProdukti
                {
                    ProduktiId = i.Produkti.ProduktiId,
                    MeniId = i.Meni.MeniId,
                    Naziv = i.Produkti.Naziv,
                    NazivMenija = i.Meni.Naziv,
                    Opis = i.Produkti.Opis,
                    Cijena = i.Produkti.Cijena,
                    KategorijaId = i.Produkti.Kategorija.KategorijaId,
                    SlikaThumb = i.Produkti.SlikaThumb,
                    Rating = i.Produkti.Rating ?? 0,
                    RestoranId=i.Meni.RestoranId,
                    sastojciList = _context.ProduktiSastojci.Where(j=>j.ProduktiId == i.Produkti.ProduktiId).Select(j=> new MProduktiSastojci
                    {
                        ProduktiId= j.ProduktiId,
                        NazivSastojka=j.Sastojci.Naziv,
                        SastojciId=j.SastojciId
                        
                    }).ToList()
                     
                  
                }).ToList();

            var distinct = result.GroupBy(x => x.ProduktiId, (key, group) => group.First());

            return _mapper.Map<List<MMeniProdukti>>(distinct);
        }
    }
}
