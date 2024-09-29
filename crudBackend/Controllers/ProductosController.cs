using crudBackend.Data;
using crudBackend.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;


[Route("api/[controller]")]
[ApiController]
public class ProductosController : ControllerBase
{
    private readonly ApplicationDbContext _context;

    public ProductosController(ApplicationDbContext context)
    {
        _context = context;
    }

    // GET: api/productos
    [HttpGet]
    public ActionResult<IEnumerable<Producto>> GetProductos()
    {
        return _context.Productos.ToList();
    }

    // GET: api/productos/5
    [HttpGet("{id}")]
    public ActionResult<Producto> GetProducto(int id)
    {
        var producto = _context.Productos.Find(id);

        if (producto == null)
        {
            return NotFound();
        }

        return producto;
    }

    // POST: api/productos
    [HttpPost]
    public ActionResult<Producto> PostProducto(Producto producto)
    {
        _context.Productos.Add(producto);
        _context.SaveChanges();

        return CreatedAtAction(nameof(GetProducto), new { id = producto.Id }, producto);
    }

    // PUT: api/productos/5
    [HttpPut("{id}")]
    public IActionResult PutProducto(int id, Producto producto)
    {
        if (id != producto.Id)
        {
            return BadRequest();
        }

        _context.Entry(producto).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        _context.SaveChanges();

        return NoContent();
    }

    // DELETE: api/productos/5
    [HttpDelete("{id}")]
    public IActionResult DeleteProducto(int id)
    {
        var producto = _context.Productos.Find(id);
        if (producto == null)
        {
            return NotFound();
        }

        _context.Productos.Remove(producto);
        _context.SaveChanges();

        return NoContent();
    }
}

