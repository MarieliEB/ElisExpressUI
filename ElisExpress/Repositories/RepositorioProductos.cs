using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using ElisExpress.Models;
using ElisExpress.Controllers;
using ElisExpress.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Nancy.Json;
using System.Text.Json;
using Newtonsoft.Json;
using System.Text;

namespace ElisExpress.Repositories
{
    public class RepositorioProductos
    {

        public List<Producto> ObtenerProductos()
        {
            var productos = new List<Producto>();

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44345/api/productos");
                
                //HTTP GET
                var responseTask = client.GetAsync("");
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsStringAsync();
                    readTask.Wait();

                    var productosJson = readTask.Result;
                    productos = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Producto>>(productosJson);
                }
                return productos;
            }
        }

        public void CrearProducto(Producto producto)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44345/api/productos");

                //HTTP POST
                StringContent content = new StringContent(JsonConvert.SerializeObject(producto), Encoding.UTF8, "application/json");
                var postTask = client.PostAsync("Productos", content);
                var result = postTask.Result;

                if (result.IsSuccessStatusCode)
                {
                    //return RedirectToAction("Index");
                }
            }
        }
    }



    //[HttpPost]
    //public IActionResult CrearProducto(Producto producto)
    //{
    //    repositorioProductos.create(producto); //Ir a la base de datos a guardarlo 
    //    return RedirectToAction("Productos");
    //}

} // FIn
