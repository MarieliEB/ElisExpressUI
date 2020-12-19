using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppCore;
using Entities;
using Management;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/facturas")]
    [ApiController]
    public class FacturaController : ControllerBase
    {

        [HttpGet]
        public List<Factura> Get()
        {
            var fac = new FacturaManagement();
            return fac.RetrieveAll();
        }

        [HttpGet("{id}")]
        public ActionResult GetById(int id)
        {
            try
            {
                var fac = new FacturaManagement();
                Factura factura = new Factura();
                factura.Id = id;
                if (factura.Id < 1)
                {
                    return NotFound();
                }

                return Ok(fac.RetrieveById(factura));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { msg = ex.Message });
            }
        }

        [HttpPost]
        public IActionResult Create(Factura factura)
        {
            try
            {
                var fac = new FacturaManagement();
                fac.Create(factura);

                return Ok(new { msg = "Se registro con exito" });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { msg = ex.Message });
            }
        }

        [HttpPut("{id}")]
        public IActionResult Update(Factura factura, int id)
        {
            try
            {
                var fac = new FacturaManagement();
                factura.Id = id;

                if (GetById(id) == null)
                {
                    return StatusCode(500, new { msg = "No se encontró dicha factura" });
                }
                else
                {
                    fac.Update(factura);
                    return Ok(new { msg = "Se actualizó con exito" });
                }

            }
            catch (Exception ex)
            {
                return StatusCode(500, new { msg = ex.Message });
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                var fac = new FacturaManagement();
                var factura = new Factura { Id = id };
                fac.Delete(factura);

                return Ok(new { msg = "Se eliminó la factura" });

            }
            catch (Exception ex)
            {
                return StatusCode(500, new { msg = ex.Message });
            }
        }
    }
}
