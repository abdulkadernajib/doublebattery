using System.Linq;
using System.Threading.Tasks;
using doublebattery.Core;
using doublebattery.Core.Models;
using doublebattery.Models;
using Microsoft.EntityFrameworkCore;

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

        public async Task<Product> GetProducts(Filter filter)
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

            if (filter.BrandId.HasValue)
                query = query.Where(v => v.Model.BrandId == filter.BrandId.Value)

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