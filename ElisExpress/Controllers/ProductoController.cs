using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using ElisExpress.Models;
using ElisExpress.Repositories;
using ElisExpress.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace ElisExpress.Controllers
{
    public class ProductoController : Controller
    {
        private RepositorioProductos repositorioProductos;
        private IConfiguration Configuration;
        private string ApiBaseUrl;

        public ProductoController(RepositorioProductos repositorioProductos, IConfiguration configuration)
        {
            this.repositorioProductos = repositorioProductos;
            Configuration = configuration;

            ApiBaseUrl = Configuration.GetValue<string>("WebAPIBaseUrl");
        }

        public IActionResult Productos()
        {

            var modelo = new ProductoViewModel();

            modelo.Productos = repositorioProductos.ObtenerProductos();

            return View(modelo);
        }


        public ActionResult create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Producto producto)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44345/api/productost");

                //HTTP POST
                //var postTask = client.PostAsync(producto); //<Producto>("producto", producto);
                //var result = postTask.Result;
                //if (result.IsSuccessStatusCode)
                //{
                //    return RedirectToAction("Index");
                //}
            }

            ModelState.AddModelError(string.Empty, "Server Error. Please contact administrator.");

            return View(producto);
        }

        [HttpPost]
        public IActionResult CrearProducto(Producto producto)
        {
            Create(producto); //Ir a la base de datos a guardarlo 
            return RedirectToAction("Productos");
        }




    } // FIN
}
