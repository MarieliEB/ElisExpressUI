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
    public class CarritoController : Controller
    {
        private RepositorioCarritos repositorioCarritos;
        private IConfiguration Configuration;
        private string ApiBaseUrl;

        public CarritoController(RepositorioCarritos repositorioCarritos, IConfiguration configuration)
        {
            this.repositorioCarritos = repositorioCarritos;
            Configuration = configuration;

            ApiBaseUrl = Configuration.GetValue<string>("WebAPIBaseUrl");
        }

        public IActionResult Carritos()
        {

            var modelo = new CarritoViewModel();

            modelo.Carritos = repositorioCarritos.ObtenerCarritos();

            return View(modelo);
        }


        public ActionResult create()
        {
            return View();
        }


    } // FIN
}
