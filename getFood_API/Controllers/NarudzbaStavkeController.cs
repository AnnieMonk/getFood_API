using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using getFood_API.Services;
using getFood_Model;
using getFood_Model.Requests;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace getFood_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NarudzbaStavkeController : BaseCRUDController<MNarudzbaStavke, NarudzbaStavkeSearchRequest, NarudzbaStavkeUpsertRequest, NarudzbaStavkeUpsertRequest>
    {
        public NarudzbaStavkeController(ICRUDService<MNarudzbaStavke, NarudzbaStavkeSearchRequest, NarudzbaStavkeUpsertRequest, NarudzbaStavkeUpsertRequest> service) : base(service)
        {
        }
    }
}