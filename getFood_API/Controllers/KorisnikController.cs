using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using getFood_API.Services;
using getFood_Model;
using getFood_Model.Requests;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace getFood_API.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController] //tjera nas da poštujemo rest konveciju
    public class KorisnikController : ControllerBase
    {
        private readonly IKorisnikServis _korisniciServis;
        public KorisnikController(IKorisnikServis service)
        {
            _korisniciServis = service;
        }

        [Authorize]
        [HttpGet]
        public List<MKorisnik> Get([FromQuery] KorisnikSearchRequest request)
        {
            return _korisniciServis.GetKorisnici(request);
        }


        [Authorize]
        [HttpGet("{id}")]
        public MKorisnik GetById(int id)
        {
            return _korisniciServis.GetById(id);
        }


        [AllowAnonymous]
        [HttpPost]
        public MKorisnik Insert(KorisnikUpsertRequest request)
        {
            return _korisniciServis.Insert(request);
        }
        [AllowAnonymous]
        [HttpPut("{id}")]
        public MKorisnik Update(int id, KorisnikUpsertRequest request)
        {
            return _korisniciServis.Update(id, request);
        }
        [AllowAnonymous]
        [HttpPost("authenticate")]
        public async Task<IActionResult> Authenticate(string username, string password)
        {
            var user = await _korisniciServis.Authenticate(username, password);

            if (user == null)
                return BadRequest(new { message = "Username or password is incorrect" });

            return Ok(user);
        }

      
    }
}
