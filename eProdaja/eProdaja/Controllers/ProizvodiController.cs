using eProdaja.Model.Requests;
using eProdaja.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eProdaja.Controllers
{

    public class ProizvodiController : BaseCRUDController<Model.Proizvodi, ProizvodiSearchRequest, ProizvodiInsertRequest, ProizvodiUpdateRequest>
    {
        //public ProizvodiController(ICRUDService<Proizvodi, ProizvodiSearchRequest, ProizvodiInsertRequest, ProizvodUpdateRequest> service) : base(service)
        //{
        //}
        public ProizvodiController(IProizvodiService service) : base(service)
        {
        }
    }
}
