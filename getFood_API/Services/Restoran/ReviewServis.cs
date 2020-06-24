using AutoMapper;
using getFood_API.Database;
using getFood_Model;
using getFood_Model.Requests;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace getFood_API.Services.Restoran
{
    public class ReviewServis : BaseCRUDService<MReview, ReviewSearchRequest, Database.Review, ReviewUpsertRequest, ReviewUpsertRequest>
    {
        public ReviewServis(getFoodContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public override List<MReview> Get(ReviewSearchRequest search)
        {
            var query = _context.Set<Database.Review>().AsQueryable();

            if (search?.Ime != null)
            {
                query = query.Include(i=>i.Korisnik).Where(x => x.Korisnik.Ime == search.Ime);
            }
            if (search?.Ocjena.HasValue == true)
            {
                query = query.Where(x => x.Ocjena == search.Ocjena);
            }
            if (search?.ProduktId.HasValue == true)
            {
                query = query.Where(x => x.ProduktiId == search.ProduktId);
            }
            if (search?.RestoranId.HasValue == true)
            {
                query = query.Where(x => x.RestoranId == search.RestoranId);
            }

            // var list = query.ToList();

            var result = query
                .Include(i => i.Korisnik)

                .Select(i => new MReview
                {
                    RestoranId = i.RestoranId,
                    Datum = i.Datum,
                    Komentar = i.Komentar,
                    Ocjena = i.Ocjena,
                    KorisnikId = i.KorisnikId,
                    Ime = i.Korisnik.Ime,
                    Prezime = i.Korisnik.Prezime,
                    KorisnickoIme = i.Korisnik.KorisnickoIme,
                    ReviewId = i.ReviewId,
                    ProduktiId=i.ProduktiId
                }).ToList();

            return _mapper.Map<List<MReview>>(result);
        }

        public override MReview Insert(ReviewUpsertRequest request)
        {

            var entity = _mapper.Map<Database.Review>(request);

            _context.Set<Database.Review>().Add(entity);
            _context.SaveChanges();

            if(request.ProduktiId != null)
            {
                //pronaji prvo produkt
                var produkt = _context.Produkti.Find(request.ProduktiId);
                var produktReviews = _context.Review.Where(i => i.ProduktiId == produkt.ProduktiId).ToList();
                
                decimal sabraneOcjene = 0;
              
                foreach (var x in produktReviews)
                {
                    sabraneOcjene += x.Ocjena;
                }

                decimal ukupanRating = sabraneOcjene / produktReviews.Count();

                //Update taj produkt sa novoizracunaim ratingom
                produkt.Rating = Math.Round(ukupanRating, 1);

                _context.SaveChanges();
            }

            if(request.RestoranId != null)
            {
                var restoran = _context.Restoran.Find(request.RestoranId);
                var restoranReviews = _context.Review.Where(i => i.RestoranId == request.RestoranId).ToList();

                decimal sabraneOcjene = 0;
              
                foreach (var x in restoranReviews)
                {
                    sabraneOcjene += x.Ocjena;
                }

                decimal ukupanRating = sabraneOcjene / restoranReviews.Count();

                restoran.Rating = Math.Round(ukupanRating,1);

                _context.SaveChanges();
            }

            return _mapper.Map<MReview>(entity);
        }
    }
}
