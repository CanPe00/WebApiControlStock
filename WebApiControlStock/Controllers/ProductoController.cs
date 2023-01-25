using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using WebApiControlStock.Data;
using WebApiControlStock.Models;

namespace WebApiControlStock.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : ControllerBase
    {
        private DBStockContext context;

        public ProductoController(DBStockContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Producto>> Get()
        {
            return context.Productos.Include(c=>c.Categoria).ToList();
        }

        [HttpPost]
        public ActionResult Post(Producto producto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            context.Productos.Add(producto);
            context.SaveChanges();
            return Ok();
        }

        [HttpDelete("{id}")]
        public ActionResult<Producto> Delete(int id)
        {
            Producto producto = context.Productos.Find(id);
            if (producto != null)
            {
                return NotFound();
            }
            context.Productos.Remove(producto);
            context.SaveChanges();
            return producto;
        }

        [HttpPut("{id}")]
        public ActionResult Put(int id,[FromBody]Producto producto)
        {
            if (id != producto.Id)
            {
                return BadRequest();
            }
            context.Entry(producto).State = EntityState.Modified;
            context.SaveChanges();
            return NoContent();
        }

    }
}
