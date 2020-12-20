using ElisExpress.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace ElisExpress.Repositories
{
    public class RepositorioFacturas
    {

        public List<Factura> ObtenerFacturas()
        {
            var facturas = new List<Factura>();

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44345/api/facturas");

                //HTTP GET
                var responseTask = client.GetAsync("");
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsStringAsync();
                    readTask.Wait();

                    var facturasJson = readTask.Result;
                    facturas = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Factura>>(facturasJson);
                }
                return facturas;
            }
        }

    }
}
