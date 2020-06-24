using getFood_API.Controllers;
using getFood_API.Database;
using getFood_API.Services.Produkti;
using getFood_Model;
using Microsoft.AspNetCore.Razor.Language;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;

namespace getFood_API.Util
{
    public class Recommender
    {

        private readonly getFoodContext _context = new getFoodContext();

        //statički nizovi za test


        private static readonly List<MKorisnik> _korisnici = new List<MKorisnik>()
        {
            new MKorisnik{KorisnikId =1},
            new MKorisnik{KorisnikId =2},
        };
        private static readonly List<MKategorija> _kategorije = new List<MKategorija>() 
        {
            new MKategorija{KategorijaId=1, Naziv="Pizza"},
            new MKategorija{KategorijaId=2, Naziv="Sandwich"},
            new MKategorija{KategorijaId=3, Naziv="Dessert"},
        };


        private static readonly List<MProdukti> _produkti = new List<MProdukti>()
        {
            new MProdukti{ ProduktiId=1, Naziv = "Pizza", Opis="Bosanska", KategorijaId =1},
            new MProdukti{ ProduktiId=2, Naziv = "Pizza", Opis="Montana", KategorijaId =1},
            new MProdukti{ ProduktiId=3, Naziv = "Sandwich", Opis="Calzona", KategorijaId =2},
            new MProdukti{ ProduktiId=4, Naziv = "Palačinci", Opis="Nutella", KategorijaId =3}
        };


        //IDEJA:
        // Logiranom korsiniku preporuči proizvode iz iste kategorije koju je prethodno dobro ocijenio ALI pod uslovom da su taj proizvod drugi korisnici DOBRO ocijenili
        private static readonly List<MReview> _reviews = new List<MReview>()
        {
            new MReview{ReviewId=1, Ocjena = 5, ProduktiId =1, KorisnikId=1}, //Pizza Bosanska
            new MReview{ReviewId=2, Ocjena = 5, ProduktiId =4, KorisnikId=1}, //Palačinci Nutella
            new MReview{ReviewId=3, Ocjena = 2, ProduktiId =3, KorisnikId=2}, // Sandwich Calzona
            new MReview{ReviewId=4, Ocjena = 1, ProduktiId =2, KorisnikId=2}, // Pizza Montana
            new MReview{ReviewId=5, Ocjena = 1, ProduktiId =4, KorisnikId=2}, // Palačinci Nutella
        };
        //po ovome trebalo bi samo da preporuči Pizza Bosanska, jer je već naručivao i ocijenio sa 5, kao i palačinci nutella
        // međutim ne bi trebalo da preporuči Pizza Montana (iako ima istu kategoriju kao Pizza Bosanska), jer je loše ocijenjena od strane nekog drugog kupca PROBLEM: preporučuje je
        //i ne bi trebalo da preporuči Sandwich Calzona, to svakako jer se ne poklapaju kategorije

        


        private double CalculateSimilarity(List<MReview> commonRatings1, List<MReview> commonRatings2)
        {
            if (commonRatings1.Count != commonRatings2.Count)
                return 0;

            double numerator = 0, int1 = 0, int2 = 0;

            for (int i = 0; i < commonRatings1.Count; i++)
            {
                numerator += (double)commonRatings1[i].Ocjena * (double)commonRatings2[i].Ocjena;
                int1 += Math.Pow((double)commonRatings1[i].Ocjena, 2);
                int2 += Math.Pow((double)commonRatings2[i].Ocjena, 2);

            }

            int1 = Math.Sqrt(int1);
            int2 = Math.Sqrt(int2);

            if (int1 * int2 != 0)
                return numerator / (int1 * int2);

            return 0;

        }


        private Dictionary<int, List<MReview>> kategorijeUserRatings = new Dictionary<int, List<MReview>>();
   
        private Dictionary<int, List<MReview>> kategorijeOtherUserRatings = new Dictionary<int, List<MReview>>();
  
        public List<MProdukti> GetPreporuceni(int currentUserId)
        {
            StaUserVoli(currentUserId);
            //sada imamo listu ocijenjenih kategorija od strane specifičnog usera


            //ovdje izvlacim ocjene ostalih korisnika
          
            var sveStoSuOcijeniliOstali = _reviews.Where(i => i.KorisnikId != currentUserId).ToList();
            
            foreach(var x in sveStoSuOcijeniliOstali)
            {
                
                foreach(var y in _produkti) { 

                    if(x.ProduktiId == y.ProduktiId)
                    {
                        if (!kategorijeOtherUserRatings.ContainsKey(y.KategorijaId))
                            kategorijeOtherUserRatings.Add(y.KategorijaId, sveStoSuOcijeniliOstali.Where(i=>i.ProduktiId == y.ProduktiId).ToList()); //sada ova lista ima ocjene ostalih usera u njihove kategorije
                    }
                }
            }

            List<MReview> ocjene1 = new List<MReview>();
       
            List<MReview> ocjene2 = new List<MReview>();
       

          
            List<MProdukti> preporuceniProizvodi = new List<MProdukti>(); //ovdje cu na kraju da smjestim koji produkti da se preporuče ali na osnovu kategorija koje USER voli 


            //OVDJE NASTAJE PROBLEMATIKA
            foreach (var x in kategorijeUserRatings)
            {
                foreach (var y in kategorijeOtherUserRatings)
                {

                    if (x.Key == y.Key) //ako se poklapaju kategorije
                    {
                                                ocjene1.Add(x.Value.FirstOrDefault());
                        ocjene2.Add(y.Value.FirstOrDefault());
                    }

                }
                double slicnost = CalculateSimilarity(ocjene1, ocjene2);
                if (slicnost > 0.5)
                {
                    foreach(var z in _produkti.Where(i=>i.KategorijaId == x.Key).ToList())
                    {
                        preporuceniProizvodi.Add(z);
                    }
            
                }

         
            }
            return preporuceniProizvodi;
        }


        //ovdje izvlačim kategorije nekog proizvoda na osnovu user-ovih ocijenjenih do sada.
        private void StaUserVoli(int currentUserId)
        {
            //dobavi sve sto je on lajkao, i vidi koje su to kategirije

            // var sveStoJeOcijenoSpecificni = _context.Review.Where(i => i.KorisnikId == currentUserId && i.ProduktiId != null).ToList();
            var sveStoJeOcijenoSpecificni = _reviews.Where(i => i.KorisnikId == currentUserId).ToList();

            //var sviProdukti = _context.Produkti.ToList();
            var sviProdukti = _produkti.ToList();

            foreach(var x in sveStoJeOcijenoSpecificni)
            {
                foreach(var y in sviProdukti)
                {
                    if(x.ProduktiId == y.ProduktiId)
                    {
                        if(!kategorijeUserRatings.ContainsKey(y.KategorijaId))
                            kategorijeUserRatings.Add(y.KategorijaId, sveStoJeOcijenoSpecificni.Where(i=>i.ProduktiId == y.ProduktiId).ToList());//sad se ovdje nalazi kategorija i ocjene za nju
                    }

                }
         
            }
        }
       



    }

}

