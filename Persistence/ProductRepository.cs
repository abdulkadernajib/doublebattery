using System.Linq;
using System.Threading.Tasks;
using doublebattery.Core;
using doublebattery.Core.Models;
using doublebattery.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq.Expressions;
using System;
using doublebattery.Extension;

namespace doublebattery.Persistence
{

    public class ProductRepository : IProductRepository
    {
        private readonly DoubleBatteryDbContext context;
        public ProductRepository(DoubleBatteryDbContext context)
        {
            this.context = context;

        }
        public async Task<Product> GetProduct(int id, bool includeRelated = true)
        {
            if (!includeRelated)
                return await context.Product.FindAsync(id);

            return await context.Product
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
        }

        public async Task<IEnumerable<Product>> GetProducts(ProductQuery queryObject)
        {
            var query = context.Product
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
            // .ToListAsync()
            .AsQueryable();

            if (queryObject.BrandId.HasValue)
                query = query.Where(v => v.Model.BrandId == queryObject.BrandId.Value);

            var ColumnsMaping = new Dictionary<string, Expression<Func<Product, object>>>()
            {
                ["brand"] = p => p.Model.Brand.Name,
                ["model"] = p => p.Model.BrandModelId
            };
            query = query.ApplyOrdering(queryObject, ColumnsMaping);

            // if (queryObject.SortBy == "brand")
            //     query = (queryObject.IsSortAssending) ? query.OrderBy(p => p.Model.Brand.Name) : query.OrderByDescending(p => p.Model.Brand.Name);


            return await query.ToListAsync();
        }




        public void Add(Product product)
        {
            context.Product.Add(product);
        }
        public void Delete(Product product)
        {
            context.Product.Remove(product);
        }
        // to load few related property and not complete
        // public async Task<Product> GetProductWithModel()
        // {

        // }

    }
}