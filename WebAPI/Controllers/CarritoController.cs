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
    [Route("api/carrito")]
    [ApiController]
    public class CarritoController : ControllerBase
    {

        [HttpGet]
        public List<Carrito> Get()
        {
            var car = new CarritoManagement();
            return car.RetriveAll();
        }

        [HttpGet("{id}")]
        public ActionResult GetById(int id)
        {
            try
            {
                var car = new CarritoManagement();
                Carrito carrito = new Carrito();
                carrito.Id = id;
                if (carrito.Id < 1)
                {
                    return NotFound();
                }

                return Ok(car.RetriveById(carrito));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { msg = ex.Message });
            }
        }

        [HttpPost]
        public IActionResult Create(Carrito carrito)
        {
            try
            {
                var car = new CarritoManagement();
                car.Create(carrito);

                return Ok(new { msg = "Se registro con exito" });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { msg = ex.Message });
            }
        }

        [HttpPut("{id}")]
        public IActionResult Update(Carrito carrito, int id)
        {
            try
            {
                var car = new CarritoManagement();
                carrito.Id = id;

                if (GetById(id) == null)
                {
                    return StatusCode(500, new { msg = "No se encontró dicha carrito" });
                }
                else
                {
                    car.Update(carrito);
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
                var car = new CarritoManagement();
                var carrito = new Carrito { Id = id };
                car.Delete(carrito);

                return Ok(new { msg = "Se eliminó el carrito" });

            }
            catch (Exception ex)
            {
                return StatusCode(500, new { msg = ex.Message });
            }
        }
    }
}

