using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using doublebattery.Controllers.Resources;
using doublebattery.Models;
using doublebattery.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace doublebattery.Controllers
{
    public class BrandsController : Controller
    {
        private readonly DoubleBatteryDbContext Context;
        private readonly IMapper mapper;
        public BrandsController(DoubleBatteryDbContext context, IMapper mapper)
        {
            this.mapper = mapper;
            this.Context = context;

        }
        [HttpGet("/api/brands")]
        public async Task<IEnumerable<BrandResource>> GetBrands()
        {
            var brands = await Context.Brand.Include(b => b.Models).ToListAsync();
            return mapper.Map<List<Brand>, List<BrandResource>>(brands);
        }


    }
}