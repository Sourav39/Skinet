using Core.Entities;
using Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        public StoreContext _context { get; }
        public ProductsController(StoreContext context)
        {
            _context = context;
            
        }
        [HttpGet]
        public async Task<ActionResult<List<Products>>> GetProducts(){
           var products = await _context.Products.ToListAsync();

           return   products;
        }
    }
}