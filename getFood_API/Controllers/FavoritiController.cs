﻿using System;
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
    public class FavoritiController : BaseCRUDController<MFavoriti, FavoritiSearchRequest, FavoritiUpsertRequest, FavoritiUpsertRequest>
    {
        public FavoritiController(ICRUDService<MFavoriti, FavoritiSearchRequest, FavoritiUpsertRequest, FavoritiUpsertRequest> service) : base(service)
        {
        }
    }
}
