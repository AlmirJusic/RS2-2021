using AutoMapper;
using eProdaja.Database;
using eProdaja.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eProdaja.Services
{
    public class KorisniciService : IKorisniciService
    {
        public eProdajaContext Context { get; set; }
        protected readonly IMapper _mapper;

        public KorisniciService(eProdajaContext context,IMapper mapper)
        {
            Context = context;
            _mapper = mapper;
        }
        public List<Model.Korisnici> Get(KorisniciSearchRequest request)
        {
            var query = Context.Korisnicis.AsQueryable();
            if(!string.IsNullOrEmpty(request?.Ime))
            {
                query = query.Where(x => x.Ime.Contains(request.Ime));
            }
            var list = query.ToList();
            return _mapper.Map<List<Model.Korisnici>>(list);
        }

        public Model.Korisnici Insert(KorisniciInsertRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
