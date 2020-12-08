using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using doublebattery.Core;
using doublebattery.Core.Models;
using doublebattery.Models;
using doublebattery.Persistence;
using Microsoft.AspNetCore.Mvc;

namespace doublebattery.Controllers.Resources
{
    [Route("/api/products")]
    public class ProductsController : Controller
    {
        private readonly IMapper mapper;
        private readonly IProductRepository repository;
        private readonly IUnitOfWork unitOfWork;

        public ProductsController(
            IMapper mapper,
            IProductRepository repository,
            IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
            this.repository = repository;
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


            repository.Add(product);
            await unitOfWork.CompleteAsync();


            product = await repository.GetProduct(product.Id);

            var result = mapper.Map<Product, ProductsResource>(product);
            return Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateProduct(int id, [FromBody] SaveProductResource productResource)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var product = await repository.GetProduct(id);

            if (product == null)
                return NotFound();
            mapper.Map<SaveProductResource, Product>(productResource, product);
            product.LastUpdate = DateTime.Now;

            await unitOfWork.CompleteAsync();

            product = await repository.GetProduct(product.Id);
            var result = mapper.Map<Product, ProductsResource>(product);
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            var product = await repository.GetProduct(id, includeRelated: false);

            if (product == null)
                return NotFound();
            repository.Delete(product);
            await unitOfWork.CompleteAsync();
            return Ok();
        }



        [HttpGet("{id}")]
        public async Task<IActionResult> GetProduct(int id)
        {
            var product = await repository.GetProduct(id);

            if (product == null)
                return NotFound();

            var productResource = mapper.Map<Product, ProductsResource>(product);
            return Ok(productResource);
        }

        [HttpGet]
        public async Task<IEnumerable<ProductsResource>> GetProducts(ProductQueryResource filterResource)
        {
            var filter = mapper.Map<ProductQueryResource, ProductQuery>(filterResource);
            var product = await repository.GetProducts(filter);
            return mapper.Map<IEnumerable<Product>, IEnumerable<ProductsResource>>(product);
        }

        //  [HttpGet("{id}")]
        // public async Task<IActionResult> GetProductByModel(int id)
        // {
        // var product = await context.Product.Include(p => p.Model).ToListAsync(id)
        // [HttpGet]
        //     public async Task<QueryResultResource<ProductsResource>> GetVehicles(VehicleQueryResource filterResource)
        //     {
        //       var filter = mapper.Map<VehicleQueryResource, VehicleQuery>(filterResource);
        //       var queryResult = await repository.GetVehicles(filter);

        //       return mapper.Map<QueryResult<Vehicle>, QueryResultResource<VehicleResource>>(queryResult);
        //     }


    }
}

