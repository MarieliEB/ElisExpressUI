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
    [Route("api/productos")]
    [ApiController]
    public class ProductoController : ControllerBase
    {

        [HttpGet]
        public List<Producto> Get()
        {
            var prod = new ProductoManagement();
            return prod.RetrieveAll();
        }

        [HttpGet("{id}")]
        public ActionResult GetById(int id)
        {
            try
            {
                var prod = new ProductoManagement();
                Producto producto = new Producto();
                producto.Id = id;
                if (producto.Id < 1)
                {
                    return NotFound();
                }

                return Ok(prod.RetrieveById(producto));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { msg = ex.Message });
            }
        }

        [HttpPost]
        public IActionResult Create(Producto producto)
        {
            try
            {
                var prod = new ProductoManagement();
                prod.Create(producto);

                return Ok(new { msg = "Se registro con exito" });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { msg = ex.Message });
            }
        }

        [HttpPut("{id}")]
        public IActionResult Update(Producto producto, int id)
        {
            try
            {
                var prod = new ProductoManagement();
                producto.Id = id;

                if (GetById(id) == null)
                {
                    return StatusCode(500, new { msg = "No se encontró dicho producto" });
                }
                else
                {
                    prod.Update(producto);
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
                var prod = new ProductoManagement();
                var producto = new Producto { Id = id };
                prod.Delete(producto);

                return Ok(new { msg = "Se eliminó el producto" });

            }
            catch (Exception ex)
            {
                return StatusCode(500, new { msg = ex.Message });
            }
        }
    }
}
