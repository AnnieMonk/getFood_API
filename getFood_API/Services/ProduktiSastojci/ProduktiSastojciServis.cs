using AutoMapper;
using AutoMapper.QueryableExtensions;
using getFood_API.Database;
using getFood_Model;
using getFood_Model.Requests;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace getFood_API.Services.ProduktiSastojci
{
    public class ProduktiSastojciServis : BaseService<MProduktiSastojci, ProduktiSastojciSearchRequest, Database.ProduktiSastojci>
    {
        public ProduktiSastojciServis(getFoodContext context, IMapper mapper) : base(context, mapper)
        {
        }
        public override List<MProduktiSastojci> Get(ProduktiSastojciSearchRequest search)
        {
            var query = _context.Set<Database.ProduktiSastojci>().AsQueryable();

            if (search?.ProduktiId.HasValue == true)
            {
                query = query.Where(x => x.ProduktiId == search.ProduktiId);
            }

            // var list = query.ToList();

            var result = query
                .Include(i => i.Sastojci)
                .Include(i => i.Produkti)
                .Select(i => new MProduktiSastojci
                {
                    ProduktiId = i.ProduktiId,
                    SastojciId = i.SastojciId,
                    NazivSastojka = i.Sastojci.Naziv,
                    NazivProdukta = i.Produkti.Naziv
                }).ToList();

            return _mapper.Map<List<MProduktiSastojci>>(result);
        }
        
    }

    }
    
