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
    public class ProductoController : Controller
    {
        private RepositorioProductos repositorioProductos;

        public ProductoController(RepositorioProductos repositorioProductos)
        {
            this.repositorioProductos = repositorioProductos;
        }

        public IActionResult Productos()
        {

            var modelo = new ProductoViewModel();

            modelo.Productos = repositorioProductos.Productos.ToList();

            return View(modelo);
        }

        [HttpGet]
        public IActionResult CrearProducto()
        {
            return View();
        }


        [HttpPost]
        public IActionResult CrearProducto(Producto producto)
        {
            repositorioProductos.Productos.Add(producto); //Ir a la base de datos a guardarlo 
            return RedirectToAction("Productos");
        }
    }
}
