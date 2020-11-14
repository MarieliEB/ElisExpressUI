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

namespace ElisExpress.Controllers
{
    public class HomeController : Controller
    {
        private RepositorioCategorias repositorioCategorias;

        public HomeController(RepositorioCategorias repositorioCategorias)
        {
            this.repositorioCategorias = repositorioCategorias;
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
