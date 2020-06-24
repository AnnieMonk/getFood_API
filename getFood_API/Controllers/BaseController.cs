﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using getFood_API.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace getFood_API.Controllers
{
    [Authorize] //autentifikacija
    [Route("api/[controller]")]
    [ApiController]
    public class BaseController<T, TSearch> : ControllerBase
    {
        private readonly IService<T, TSearch> _service;
        public BaseController(IService<T, TSearch> service)
        {
            _service = service;
        }

        [HttpGet]
        public List<T> Get([FromQuery]TSearch search)
        {
            return _service.Get(search);
        }

        [HttpGet("{id}")]
        public T GetById(int id)
        {
            return _service.GetById(id);
        }
    }
}