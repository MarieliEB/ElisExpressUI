using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ElisExpress.Models;
using ElisExpress.Repositories;
using ElisExpress.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ElisExpress.Controllers
{
    public class CategoriaController : Controller
    {
        private RepositorioCategorias repositorioCategorias;

        public CategoriaController(RepositorioCategorias repositorioCategorias)
        {
            this.repositorioCategorias = repositorioCategorias;
        }

        public IActionResult Categorias()
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
            return RedirectToAction("Categorias");
        }
    }
}
