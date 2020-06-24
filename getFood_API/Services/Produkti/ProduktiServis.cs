using AutoMapper;
using getFood_API.Database;
using getFood_Model;
using getFood_Model.Requests;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace getFood_API.Services.Produkti
{
    public class ProduktiServis : BaseCRUDService<MProdukti, ProduktiSearchRequest, Database.Produkti, ProduktiUpsertRequest, ProduktiUpsertRequest>
    {
        
        public ProduktiServis(getFoodContext context, IMapper mapper) : base(context, mapper)
        {
          
        }
        public override MProdukti Update(int id, ProduktiUpsertRequest request)
        {
            var entity = _context.Produkti.Find(id);
            _mapper.Map(request, entity);
            _context.SaveChanges();

            //dodan produkt

            //sada dodati sastojke koje vec nema
            var lista = _context.ProduktiSastojci.Where(i => i.ProduktiId == id).Select(j=>j.SastojciId).ToList(); //produkt sa svim sastojcima
            var zaObrisati = lista.Except(request.Sastojci);

            //ako je uradjen uncheck
            foreach (var x in zaObrisati)
            {
                if (lista.Contains(x))
                {
                    var sastojak = _context.ProduktiSastojci.Where(i => i.SastojciId == x).ToList();
                    foreach (var y in sastojak)
                    {
                        _context.Set<Database.ProduktiSastojci>().Remove(y);
                    }

                }
            }



            foreach (var j in request.Sastojci)
                {
                    if(!lista.Contains(j))
                    {
                        //ako nije isti sastojak onda
                        var produktiSastojci = new Database.ProduktiSastojci();

                        produktiSastojci.ProduktiId = entity.ProduktiId;
                        produktiSastojci.Kolicina = 1;
                        produktiSastojci.SastojciId = j;

                        _context.Set<Database.ProduktiSastojci>().Add(produktiSastojci);
                    }
                }


            //
            var lista2 = _context.MeniProdukti.Where(i => i.ProduktiId == id).Select(j => j.MeniId).ToList(); //Meniji na kojima je produkt
            var izRequesta = request.Meni.ToList(); //ovo su Ide-evi

            foreach(var meni in izRequesta)
            {
                var meniProdukti = new Database.MeniProdukti();

                meniProdukti.ProduktiId = entity.ProduktiId;

                meniProdukti.MeniId = meni;

                _context.Set<Database.MeniProdukti>().Add(meniProdukti);
            }//dodavanje novih menija

            //sada brisanje starih

            var stari = lista2.Except(izRequesta).ToList();


            foreach(var meni in stari)
            {
                var nadjeni = _context.MeniProdukti.Where(i => i.MeniId == meni).ToList();
                foreach(var del in nadjeni)
                {
                    if(del.ProduktiId == id)
                        _context.Set<Database.MeniProdukti>().Remove(del);
                }
                
            }


            //var zaObrisati2 = lista2.Except(request.Meni); //izvući one koji se nalaze u listi ali ne u requestu i pripremiti za brisanje
            ////sada proci kroz listu i vidjeti da li sadrzi neki meni iz requesta
            //foreach (var x in zaObrisati2)
            //{
            //    if (lista2.Contains(x))
            //    {//ako lista2 uopće sadrži ovo što trebam obrisati, onda obrisati
            //        var meni = _context.MeniProdukti.Where(i => i.MeniId == x).ToList();
            //        foreach (var y in meni)
            //        {
            //            _context.Set<Database.MeniProdukti>().Remove(y);
            //        }

            //    }
            //}
            //foreach (var j in request.Meni)
            //{
            //    if (!lista2.Contains(j))
            //    {
            //        //ako nije isti meni onda
            //        var meniProdukti = new Database.MeniProdukti();

            //        meniProdukti.ProduktiId = entity.ProduktiId;
                    
            //        meniProdukti.MeniId = j;

            //        _context.Set<Database.MeniProdukti>().Add(meniProdukti);
            //    }
            //}


            _context.SaveChanges();
            return _mapper.Map<MProdukti>(entity);

        }
        public override MProdukti Insert(ProduktiUpsertRequest request)
        {
           
            var entity = _mapper.Map<Database.Produkti>(request);

            _context.Set<Database.Produkti>().Add(entity);
            _context.SaveChanges();

            foreach (var sastojci in request.Sastojci)
            {

                var produktiSastojci = new Database.ProduktiSastojci();

                produktiSastojci.ProduktiId = entity.ProduktiId;
                produktiSastojci.Kolicina = 1;
                produktiSastojci.SastojciId = sastojci;

                 _context.Set<Database.ProduktiSastojci>().Add(produktiSastojci);
            }

            foreach (var meni in request.Meni)
            {

                var meniProdukti = new Database.MeniProdukti();

                meniProdukti.ProduktiId = entity.ProduktiId;

                meniProdukti.MeniId = meni;

                _context.Set<Database.MeniProdukti>().Add(meniProdukti);
            }
            _context.SaveChanges();

            return _mapper.Map<MProdukti>(entity);
        }
        public override List<MProdukti> Get(ProduktiSearchRequest search)
        {
            var query = _context.Produkti.AsEnumerable();

            if (!string.IsNullOrWhiteSpace(search?.Naziv))
            {
                query = query.Where(x => x.Naziv == search.Naziv);
            }
            if (search?.KategorijaId != null)
            {
                query = query.Where(x => x.KategorijaId == search.KategorijaId);
            }
           

            var list = query.ToList();
          
            return _mapper.Map<List<MProdukti>>(list);
        }

        //public override MProdukti GetById(int id)
        //{
        //    var produkt = _context.Produkti.Find(id);

        //    var result = _context.Review.Where(i => i.ProduktiId == produkt.ProduktiId).ToList();

        //    if (result.Count != 0)
        //    {
        //        decimal sabraneOcjene = 0;
        //        int brojReviews = 0;
        //        foreach (var x in result)
        //        {
        //            sabraneOcjene += x.Ocjena;
        //            brojReviews++;

        //        }

        //        var ukupnaOcjena = sabraneOcjene / brojReviews;

        //        produkt.Rating = ukupnaOcjena;
        //    }
        //    else
        //    {
        //        produkt.Rating = 0;
        //    }
        //    _context.SaveChanges();

        //    return _mapper.Map<MProdukti>(produkt);
        //}
        public override bool Delete(int id)
        {
            if (id != 0)
            {
                //moras prvo obrisati produktiSastoji
                var produktiSastojci = _context.ProduktiSastojci.Where(i => i.ProduktiId == id).ToList();

                foreach (var x in produktiSastojci)
                {
                    _context.Remove(x);
                }
                _context.SaveChanges();

                var meniProdukti = _context.MeniProdukti.Where(i => i.ProduktiId == id).ToList();

                foreach (var x in meniProdukti)
                {
                    _context.Remove(x);
                }
                _context.SaveChanges();

                var produkt = _context.Produkti.Find(id);

                _context.Remove(produkt);

                _context.SaveChanges();
                return true;
            }
            return false;

        }



    }
}
