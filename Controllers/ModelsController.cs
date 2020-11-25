using System;
using System.Threading.Tasks;
using AutoMapper;
using doublebattery.Controllers.Resources;
using doublebattery.Models;
using doublebattery.Persistence;
using Microsoft.AspNetCore.Mvc;

namespace doublebattery.Controllers
{
    // [Route("/api/models")]
    public class ModelsController : Controller
    {
        private readonly IMapper mapper;
        private readonly DoubleBatteryDbContext context;
        public ModelsController(IMapper mapper, DoubleBatteryDbContext context)
        {
            this.context = context;
            this.mapper = mapper;

        }
        [HttpPost("/api/models")]
        public async Task<IActionResult> CreateModel([FromBody] ModelResource modelResource)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var model = mapper.Map<ModelResource, Model>(modelResource);
            model.CreationDate = DateTime.Now;

            context.Models.Add(model);
            await context.SaveChangesAsync();

            var result = mapper.Map<Model, ModelResource>(model);
            return Ok(result);
        }


    }
}