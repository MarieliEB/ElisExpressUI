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
    [Route("api/imagenes")]
    [ApiController]
    public class ImagenPorProductoController : ControllerBase
    {

        [HttpGet]
        public List<ImagenPorProducto> Get()
        {
            var im = new ImagenPorProductoManagement();
            return im.RetrieveAll();
        }

        [HttpGet("{id}")]
        public ActionResult GetById(int id)
        {
            try
            {
                var im = new ImagenPorProductoManagement();
                ImagenPorProducto imagen = new ImagenPorProducto();
                imagen.Id = id;
                if (imagen.Id < 1)
                {
                    return NotFound();
                }

                return Ok(im.RetrieveById(imagen));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { msg = ex.Message });
            }
        }

        [HttpPost]
        public IActionResult Create(ImagenPorProducto imagen)
        {
            try
            {
                var im = new ImagenPorProductoManagement();
                im.Create(imagen);

                return Ok(new { msg = "Se registro con exito" });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { msg = ex.Message });
            }
        }

        [HttpPut("{id}")]
        public IActionResult Update(ImagenPorProducto imagen, int id)
        {
            try
            {
                var im = new ImagenPorProductoManagement();
                imagen.Id = id;

                if (GetById(id) == null)
                {
                    return StatusCode(500, new { msg = "No se encontró dicha imagen" });
                }
                else
                {
                    im.Update(imagen);
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
                var im = new ImagenPorProductoManagement();
                var imagen = new ImagenPorProducto { Id = id };
                im.Delete(imagen);

                return Ok(new { msg = "Se eliminó la imagen" });

            }
            catch (Exception ex)
            {
                return StatusCode(500, new { msg = ex.Message });
            }
        }
    }
}
