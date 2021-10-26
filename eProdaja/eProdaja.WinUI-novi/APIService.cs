using Flurl.Http;
using Flurl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eProdaja.Model;

namespace eProdaja.WinUI_novi
{
    public class APIService
    {
        private string _route = null;
        public APIService(string route)
        {
            _route = route;
        }
        public async Task<T> Get<T>(object searchrequest)
        {
            var url =  $"{Properties.Settings.Default.ApiURL}/{_route}";
            if(searchrequest!=null)
            {
                url += "?";
                url += await searchrequest.ToQueryString();
            }
            var result = await url.GetJsonAsync<T>();
            
            return result;
            
        }
        public async Task<T> GetById<T>(object id)
        {
            var url = $"{Properties.Settings.Default.ApiURL}/{_route}/{id}";
            var result=await url.GetJsonAsync<T>();
            return result;
        }
        public async Task<T> Insert<T>(object request)
        {
            var url =  $"{Properties.Settings.Default.ApiURL}/{_route}";
            var result=await url.PostJsonAsync(request).ReceiveJson<T>();
            return result;
        }
        public async Task<T> Update<T>(object id,object model)
        {
            var url =  $"{Properties.Settings.Default.ApiURL}/{_route}/{id}";
            var result = await url.PutJsonAsync(model).ReceiveJson<T>();
            return result;
        }
    }
}
