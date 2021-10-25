using AutoMapper;
using eProdaja.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eProdaja.Services
{
    public class VrsteProizvodumService : BaseService<Model.VrsteProizvodum, object, Database.VrsteProizvodum>, IVrsteProizvodumService
    {
        public VrsteProizvodumService(eProdajaContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}
