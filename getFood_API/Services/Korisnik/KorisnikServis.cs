using getFood_API.Database;
using getFood_Model;
using getFood_Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using getFood_API.Exceptions;
using System.Security.Cryptography;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using System.Threading;
using System.Security.Principal;
using Microsoft.AspNetCore.Http;

namespace getFood_API.Services
{
    public class KorisnikServis : IKorisnikServis
    {
        private readonly getFoodContext _context;
        private readonly IMapper _mapper;
      
        public KorisnikServis(getFoodContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
          
        }
       
        public MKorisnik GetById(int id)
        {
            var rezultat = _context.Korisnik.Find(id);

            return _mapper.Map<MKorisnik>(rezultat);
        }
    

        public List<MKorisnik> GetKorisnici(KorisnikSearchRequest request)
        {
            var rezultat = _context.Korisnik.AsQueryable();

            if (!string.IsNullOrWhiteSpace(request?.Ime))
            {
                rezultat = rezultat.Where(x => x.Ime == request.Ime);
            }
            if (!string.IsNullOrWhiteSpace(request?.Prezime))
            {
                rezultat = rezultat.Where(x => x.Prezime == request.Prezime);
            }
            if (!string.IsNullOrWhiteSpace(request?.KorisnickoIme))
            {
                rezultat = rezultat.Where(x => x.KorisnickoIme == request.KorisnickoIme);
            }
            if (request.KorisnikId != null)
                rezultat = rezultat.Where(i => i.KorisnikId == request.KorisnikId);


            var list = rezultat.ToList();

            return _mapper.Map<List<MKorisnik>>(list);
        }
        public static string GenerateSalt()
        {
            var buf = new byte[16];
            (new RNGCryptoServiceProvider()).GetBytes(buf);
            return Convert.ToBase64String(buf);
        }

        public static string GenerateHash(string salt, string password)
        {
            byte[] src = Convert.FromBase64String(salt);
            byte[] bytes = Encoding.Unicode.GetBytes(password);
            byte[] dst = new byte[src.Length + bytes.Length];

            System.Buffer.BlockCopy(src, 0, dst, 0, src.Length);
            System.Buffer.BlockCopy(bytes, 0, dst, src.Length, bytes.Length);

            HashAlgorithm algorithm = HashAlgorithm.Create("SHA1");
            byte[] inArray = algorithm.ComputeHash(dst);
            return Convert.ToBase64String(inArray);
        }

        public MKorisnik Insert(KorisnikUpsertRequest request)
        {
            var entity = _mapper.Map<Database.Korisnik>(request);
            entity.Status = true;
            if (request.Password != request.PasswordConfirmation)
            {


                throw new UserException("Passwordi se ne slažu");
            }
            entity.LozinkaSalt = GenerateSalt();

            entity.LozinkaHash = GenerateHash(entity.LozinkaSalt, request.Password);

            _context.Korisnik.Add(entity);

            _context.SaveChanges();

            foreach (var uloga in request.Uloge)
            {
                _context.KorisnikUloga.Add(new KorisnikUloga()
                {
                    
                    DatumPromjene = DateTime.Now,
                    KorisnikId = entity.KorisnikId,
                    UlogaId = uloga
                });
            }
            _context.SaveChanges();
            return _mapper.Map<MKorisnik>(entity);
        }

        public MKorisnik Update(int id, KorisnikUpsertRequest request)
        {
            var entity = _context.Korisnik.Find(id);
           

            if (!string.IsNullOrWhiteSpace(request.Password))
            {
                if (request.Password != request.PasswordConfirmation)
                {
                    throw new UserException("Passwordi se ne slažu");
                }
                entity.LozinkaSalt = GenerateSalt();

                entity.LozinkaHash = GenerateHash(entity.LozinkaSalt, request.Password);
                _context.SaveChanges();
            }
            _mapper.Map(request, entity);
            _context.SaveChanges();

            return _mapper.Map<MKorisnik>(entity);

        }

        public async Task<MKorisnik> Authenticate(string username, string password)
        {
            var user = await Task.Run(() => _context.Korisnik.SingleOrDefault(x => x.KorisnickoIme == username));
            if (user != null)
            {
                //moramo pretvoriti u hash da bi provjerili slaze li se sa onim u bazi
                var newHash = GenerateHash(user.LozinkaSalt, password);

                if (newHash == user.LozinkaHash) //ovo znaci da je ispravan password
                {
                    return _mapper.Map<MKorisnik>(user);
                }
            }
            return null;
        }

        
    }
}
