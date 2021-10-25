using eProdaja.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eProdaja.Controllers
{

    public class VrsteProizvodumController : BaseController<Model.VrsteProizvodum, object>
    {
        public VrsteProizvodumController(IVrsteProizvodumService service) : base(service)
        {

        }
    }
}
