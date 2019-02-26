using ConsoleWebApiCall.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleWebApiCall
{
    public class Services
    {
        public async Task<List<Todos>> GetTodos(string url)
        {
            var json = new List<Todos>();
            try
            {
                using (var client = new HttpClient())
                {
                    var response = await client.GetAsync(url);
                    var obj = await response.Content.ReadAsStringAsync();
                    json = JsonConvert.DeserializeObject<List<Todos>>(obj);
                }
                return json;
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
