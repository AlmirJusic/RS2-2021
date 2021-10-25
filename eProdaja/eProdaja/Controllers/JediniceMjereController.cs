using eProdaja.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eProdaja.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class JediniceMjereController : ControllerBase
    {
        private readonly IJediniceMjereService _service;

        public JediniceMjereController(IJediniceMjereService service)
        {
            _service = service;
        }

        // GET: api/Korisnicis
        [HttpGet]
        public IEnumerable<Model.JediniceMjere> Get()
        {
            return _service.Get();
        }
        [HttpGet("{id}")]
        public Model.JediniceMjere GetById(int id)
        {
            return _service.GetById(id);
        }
        //[HttpPost]
        //public Model.Korisnici Insert([FromBody] KorisniciInsertRequest request)
        //{
        //    return _service.Insert(request);
        //}

    }
}
