using ElisExpress.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace ElisExpress.Repositories
{
    public class RepositorioCarritos
    {
        public List<Carrito> ObtenerCarritos()
        {
            var carritos = new List<Carrito>();

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44345/api/carritos");
                //HTTP GET
                var responseTask = client.GetAsync("");
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsStringAsync();
                    readTask.Wait();

                    var carritosJson = readTask.Result;
                    carritos = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Carrito>>(carritosJson);
                }
                return carritos;
            }
        }
    }
}
