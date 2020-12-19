using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ElisExpress.Models;
using ElisExpress.ViewModels;
using ElisExpress.Repositories;
using System.Configuration;
using Microsoft.Extensions.Configuration;
using System.Net.Http;

namespace ElisExpress.Controllers
{
    public class HomeController : Controller
    {
        private RepositorioCategorias repositorioCategorias;
        private IConfiguration Configuration;
        private string ApiBaseUrl;

        public HomeController(RepositorioCategorias repositorioCategorias, IConfiguration configuration)
        {
            this.repositorioCategorias = repositorioCategorias;
            Configuration = configuration;

            ApiBaseUrl = Configuration.GetValue<string>("WebAPIBaseUrl");
        }

        public IActionResult Index()
        {
            
            var modelo = new CategoriaViewModel();

            modelo.Categorias = repositorioCategorias.Categorias.ToList();

            return View(modelo);
        }

        [HttpGet]
        public IActionResult CrearCategoria()
        {
                return View();
        }


        [HttpPost]
        public IActionResult CrearCategoria(Categoria categoria)
        {
            repositorioCategorias.Categorias.Add(categoria); //Ir a la base de datos a guardarlo 
            return RedirectToAction("Index");
        }
    }
}
