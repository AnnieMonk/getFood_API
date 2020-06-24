using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using getFood_API.Database;
using getFood_API.Util;
using getFood_Model;
using getFood_Model.Requests;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace getFood_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecommenderController : ControllerBase
    {
        private getFoodContext _context = new getFoodContext();
        private readonly IMapper _mapper;

        public RecommenderController(getFoodContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        public List<MProdukti> Get ([FromQuery] RecommenderSearchRequest search)
        {
            Recommender r = new Recommender();
            var produkti = r.GetPreporuceni(search.KorisnikId);

            return _mapper.Map<List<MProdukti>>(produkti);
        }
    }
}
