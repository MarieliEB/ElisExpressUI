using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using ElisExpress.Models;
using ElisExpress.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

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

        public Boolean CrearCategoria(Categoria categoria)
        {
            var postExitoso = false;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44345/api/categorias");

                //HTTP POST
                StringContent content = new StringContent(JsonConvert.SerializeObject(categoria), Encoding.UTF8, "application/json");
                var postTask = client.PostAsync("Categorias", content);
                var result = postTask.Result;

                if (result.IsSuccessStatusCode)
                {
                    postExitoso = true;
                }
            }

            return postExitoso;
        }

        public Boolean BorrarCategoria(int id)
        {
            var deleteExitoso = false;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44345/api/");

                //HTTP DELETE
                var deleteTask = client.DeleteAsync("categorias/" + id.ToString());
                deleteTask.Wait();

                var result = deleteTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    deleteExitoso = true;
                    
                }
            }

            return deleteExitoso;

          
        }
    }
}
