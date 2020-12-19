using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities;
using Management;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/categorias")]
    [ApiController]
    public class CategoriaController : ControllerBase
    {

        [HttpGet]
        public List<Categoria> Get()
        {
            var cat = new CategoriaManagement();
            return cat.RetrieveAll();
        }

        [HttpGet("{id}")]
        public Categoria GetById(int id)
        {
            var cat = new CategoriaManagement();
            Categoria categoria = new Categoria();
            categoria.Id = id;
            return cat.RetrieveById(categoria);
        }

        [HttpPost]
        public IActionResult Create(Categoria categoria)
        {
            try
            {
                var cat = new CategoriaManagement();
                cat.Create(categoria);

                return Ok(new { msg = "Se registro con exito" });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { msg = ex.Message });
            }
        }

        [HttpPut("{id}")]
        public IActionResult Update(Categoria categoria, int id)
        {
            try
            {
                var cat = new CategoriaManagement();
                categoria.Id = id;
                
                if (GetById(id) == null)
                {
                    return StatusCode(500, new { msg = "No se encontró dicha categoria" });
                }
                else
                {
                    cat.Update(categoria);
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
                var cat = new CategoriaManagement();
                var categoria = new Categoria { Id = id };
                cat.Delete(categoria);

                return Ok(new { msg = "Se eliminó la categoria" });

            }
            catch (Exception ex)
            {
                return StatusCode(500, new { msg = ex.Message });
            }
        }
    }
}
