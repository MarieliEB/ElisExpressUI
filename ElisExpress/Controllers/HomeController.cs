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
    }
}
