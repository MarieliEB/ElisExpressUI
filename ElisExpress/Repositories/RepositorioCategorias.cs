using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using ElisExpress.Models;
using ElisExpress.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ElisExpress.Repositories
{
    public class RepositorioCategorias
    {
        public List<Categoria> ObtenerCategorias()
        {
            var categorias = new List<Categoria>();

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44345/api/categorias");
                //HTTP GET
                var responseTask = client.GetAsync("");
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsStringAsync();
                    readTask.Wait();

                    var categoriasJson = readTask.Result;
                    categorias = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Categoria>>(categoriasJson);
                }
                return categorias;
            }
        }
    }
}
