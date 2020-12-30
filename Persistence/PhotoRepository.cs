using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using doublebattery.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace doublebattery.Persistence
{
    public class PhotoRepository
    {
        private readonly DoubleBatteryDbContext context;

        public PhotoRepository(DoubleBatteryDbContext context)
        {
            this.context = context;

        }
        public async Task<IEnumerable<Photo>> GetPhotos(int productId)
        {
            return await context.Photos
            .Where(p => p.ProductId == productId)
            .ToListAsync();
        }
    }
}