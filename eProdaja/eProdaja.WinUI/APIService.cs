using Flurl.Http;
using Flurl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eProdaja.WinUI
{
    public class APIService
    {
        private string _route = null;
        public APIService(string route)
        {
            _route = route;
        }
        public async Task<T> Get<T>()
        {
            var result = await $"{Properties.Settings.Default.ApiURL}/{_route}".GetJsonAsync<T>();
            return result;
        }
    }
}
