﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using eProdaja.Database;
using eProdaja.Services;
using eProdaja.Model.Requests;

namespace eProdaja.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KorisniciController : ControllerBase
    {
        private readonly IKorisniciService _service;

        public KorisniciController(IKorisniciService service)
        {
            _service = service;
        }

        // GET: api/Korisnicis
        [HttpGet]
        public IEnumerable<Model.Korisnici> Get([FromQuery] KorisniciSearchRequest request)
        {
            return _service.Get(request);
        }
        //[HttpGet("{id")]
        //public IEnumerable<Model.Korisnici> GetById()
        //{
        //    return _service.GetById();
        //}
        [HttpPost]
        public Model.Korisnici Insert([FromBody]KorisniciInsertRequest request)
        {
            return _service.Insert(request);
        }
        
    }
}
