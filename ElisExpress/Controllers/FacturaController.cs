using ElisExpress.Repositories;
using ElisExpress.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElisExpress.Controllers
{
    public class FacturaController : Controller
    {
        private RepositorioFacturas repositorioFacturas;
        private IConfiguration Configuration;
        private string ApiBaseUrl;

        public FacturaController(RepositorioFacturas repositorioFacturas, IConfiguration configuration)
        {
            this.repositorioFacturas = repositorioFacturas;
            Configuration = configuration;

            ApiBaseUrl = Configuration.GetValue<string>("WebAPIBaseUrl");
        }

        public IActionResult Facturas()
        {

            var modelo = new FacturaViewModel();

            modelo.Facturas = repositorioFacturas.ObtenerFacturas();

            return View(modelo);
        }


        public ActionResult create()
        {
            return View();
        }
    }
}
