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
    public class CategoriaController : Controller
    {
        private RepositorioCategorias repositorioCategorias;
        private IConfiguration Configuration;
        private string ApiBaseUrl;

        public CategoriaController(RepositorioCategorias repositorioCategorias, IConfiguration configuration)
        {
            this.repositorioCategorias = repositorioCategorias;
            Configuration = configuration;

            ApiBaseUrl = Configuration.GetValue<string>("WebAPIBaseUrl");
        }

        public IActionResult Categorias()
        {

            var modelo = new CategoriaViewModel();

            modelo.Categorias = repositorioCategorias.ObtenerCategorias();

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
            var postExitoso = repositorioCategorias.CrearCategoria(categoria); //Ir a la base de datos a guardarlo 
            if (postExitoso)
            {
                return RedirectToAction("Categorias");
            }
            else
            {
                ModelState.Clear();
                ModelState.AddModelError(string.Empty, "No se pudo realizar el registro");
                return View();
            }
           
        }

        public IActionResult BorrarCategoria(int id)
        {
            var deleteExitoso = repositorioCategorias.BorrarCategoria(id);
            return RedirectToAction("Categorias");
        }
    }
}

