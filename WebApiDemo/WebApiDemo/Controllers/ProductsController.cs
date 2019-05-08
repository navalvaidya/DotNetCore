using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApiDemo.Models;

namespace WebApiDemo.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly DeloitteDBContext _context;
        public ProductsController(DeloitteDBContext context)
        {
            _context = context;
        }

        //Handel Http get to /api/Products
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Product>>> GetProducts()
        {
            return await _context.Product.ToListAsync();
        }

        [HttpGet("{id}")]
        //url api/Products/id
        public async Task<ActionResult<Product>> GetProductById(int id)
        {
            var prod = await _context.Product.FindAsync(id);
            if (prod == null)
            {
                return NotFound();
            }
            return prod;
        }


        //return value can be void but for the testability purpose "Task<ActionResult<Product>>" is used
        public async Task<ActionResult<Product>> PostProduct(Product product)
        {
            _context.Product.Add(product);
            await _context.SaveChangesAsync();
            var productfromStore = _context.Product.Where(p => p.Id == product.Id).SingleOrDefault();
            return productfromStore;
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Product>> PostProduct(int id,Product product)
        {
            if (id != product.Id)
            {
                return BadRequest();
            }
            _context.Entry(product).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                return NotFound();
            }
            var productFromStore = _context.Product.Where(p => p.Id == id).SingleOrDefault();

            return productFromStore;
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Product>> DeleteProduct(int id)
        {
            var productFromStore = _context.Product.Where(p => p.Id == id).SingleOrDefault();
            if (productFromStore == null)
            {
                return NotFound();
            }
            _context.Product.Remove(productFromStore);
            await _context.SaveChangesAsync();
            return productFromStore;
        }
    }
}