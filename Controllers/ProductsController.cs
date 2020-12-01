using System;
using System.Threading.Tasks;
using AutoMapper;
using doublebattery.Models;
using doublebattery.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace doublebattery.Controllers.Resources
{
    [Route("/api/products")]
    public class ProductsController : Controller
    {
        private readonly IMapper mapper;
        private readonly DoubleBatteryDbContext context;

        public ProductsController(IMapper mapper, DoubleBatteryDbContext context)
        {
            this.context = context;
            this.mapper = mapper;
        }
        [HttpPost]
        public async Task<IActionResult> CreateProduct([FromBody] SaveProductResource productResource)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var product = mapper.Map<SaveProductResource, Product>(productResource);
            product.CreatedOn = DateTime.Now;
            product.LastUpdate = DateTime.Now;


            context.Product.Add(product);
            await context.SaveChangesAsync();

            var result = mapper.Map<Product, SaveProductResource>(product);
            return Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateProduct(int id, [FromBody] SaveProductResource productResource)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var product = await context.Product.FindAsync(id);

            if (product == null)
                return NotFound();
            mapper.Map<SaveProductResource, Product>(productResource, product);
            product.LastUpdate = DateTime.Now;

            await context.SaveChangesAsync();

            var result = mapper.Map<Product, SaveProductResource>(product);
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            var product = await context.Product.FindAsync(id);

            if (product == null)
                return NotFound();
            context.Remove(product);
            await context.SaveChangesAsync();
            return Ok();
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetProduct(int id)
        {
            var product = await context.Product
            .Include(p => p.Model)
            .ThenInclude(m => m.Brand)
            .Include(p => p.Category)
            .Include(p => p.FrameMaterial)
            .Include(p => p.FrameColor)
            .Include(p => p.LensColor)
            .Include(p => p.LensMaterial)
            .Include(p => p.Style)
            .Include(p => p.FrameType)
            .Include(p => p.IdealFor)
            .Include(p => p.Size)
            .SingleOrDefaultAsync(p => p.Id == id);

            if (product == null)
                return NotFound();

            var productResource = mapper.Map<Product, ProductsResource>(product);
            return Ok(productResource);
        }

        //  [HttpGet("{id}")]
        // public async Task<IActionResult> GetProductByModel(int id)
        // {
        // var product = await context.Product.Include(p => p.Model).ToListAsync(id)



    }
}
}
