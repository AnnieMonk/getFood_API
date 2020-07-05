using AutoMapper;
using getFood_API.Database;
using getFood_API.Services.MeniProdukti;
using getFood_Model;
using getFood_Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace getFood_API.Services.Recommender
{
    public class RecommenderService 
    {
        private Dictionary<int, List<Review>> nisuTajProdukt = new Dictionary<int, List<Review>>();
        private readonly getFoodContext _context;

        private readonly MeniProduktiServis _meniProduktiService;
       
        private readonly IMapper _mapper;
        public RecommenderService(getFoodContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
            _meniProduktiService = new MeniProduktiServis(_context, mapper);
        }

        public List<MProdukti> GetSlicniProdukti(RecommenderSearchRequest request)
        {
            GetOstaleProdukte(request.ProduktId, request.RestoranId); //ocjene koje nisu taj produkt

            //ocjene koje jesu taj produkt
            List<Review> jesuTajProdukt = _context.Review.Where(x => x.ProduktiId == request.ProduktId && x.ProduktiId != null).OrderBy(x => x.KorisnikId).ToList();

            List<Review> ocjene1 = new List<Review>();
            List<Review> ocjene2 = new List<Review>();


            List<MProdukti> slicniProdukti = new List<MProdukti>();

            foreach (var n in nisuTajProdukt)
            {
                foreach (var j in jesuTajProdukt)
                {
                    if (n.Value.Where(x => x.KorisnikId == j.KorisnikId).Count() > 0)
                    {
                        ocjene1.Add(j); 
                        ocjene2.Add(n.Value.Where(x => x.KorisnikId == j.KorisnikId).First()); 
                    }
                }

                double sim = IzracunajSlicnost(ocjene1, ocjene2);

                if (sim > 0.7)
                {

                    var slican = GetById(n.Key);

                    slicniProdukti.Add(slican);
                }

                ocjene1.Clear();
                ocjene2.Clear();
            }

            return slicniProdukti;
        }

        private double IzracunajSlicnost(List<Review> ocjene1, List<Review> ocjene2)
        {

         
            int brojac = 0;
            if (ocjene1.Count != ocjene2.Count)
                return 0;
            else
                brojac = ocjene1.Count();

            double numerator = 0, int1 = 0, int2 = 0;

            for (int i = 0; i < brojac; i++)
            {
                numerator += (double)ocjene1[i].Ocjena * (double)ocjene2[i].Ocjena; 
                int1 += (double)ocjene1[i].Ocjena * (double)ocjene1[i].Ocjena; 
                int2 += (double)ocjene2[i].Ocjena * (double)ocjene2[i].Ocjena;
            
            }

            int1 = Math.Sqrt(int1); 
            int2 = Math.Sqrt(int2); 

            if (int1 * int2 != 0)
                return numerator / (int1 * int2); 

            return 0;

        }

        private void GetOstaleProdukte(int produktId, int restoranId)
        {
            RecommenderSearchRequest request = new RecommenderSearchRequest { ProduktId = produktId };

            List<MProdukti> produktiList = Get(request);
            List<Review> reviews;
            //isfiltirana lista, po restoranu
            var meniProdukti = _meniProduktiService.Get(new MeniProduktiSearchRequest { RestoranId = restoranId });
            foreach(var item in produktiList)
            {
                if (meniProdukti.Select(i => i.ProduktiId).Contains(item.ProduktiId))
                {
                    //ocjene koje nisu taj produkt*
                    reviews = _context.Review.Where(x => x.ProduktiId == item.ProduktiId && x.ProduktiId != null).OrderBy(x => x.KorisnikId).ToList();

                    if (reviews.Count > 0)
                    {
                        nisuTajProdukt.Add(item.ProduktiId, reviews);
                    }
                }
            }

        }


        public List<MProdukti> Get(RecommenderSearchRequest search)
        {
            var query = _context.Set<Database.Produkti>().AsQueryable();
            query = query.Where(i => i.ProduktiId != search.ProduktId);
           
            
            var list = query.ToList();

            return _mapper.Map<List<MProdukti>>(list);
        }

        public MProdukti GetById(int id)
        {
            var entity = _context.Produkti.Find(id);

            return _mapper.Map<MProdukti>(entity);
        }

    }
}
