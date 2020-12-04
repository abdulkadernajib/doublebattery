using System.Collections.Generic;
using System.Threading.Tasks;
using doublebattery.Core;
using doublebattery.Models;
using doublebattery.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

public class AttributesController : Controller
{
    private readonly DoubleBatteryDbContext context;

    public AttributesController(DoubleBatteryDbContext context)
    {
        this.context = context;

    }
    [HttpGet("/api/framematerials")]
    public async Task<IEnumerable<FrameMaterial>> GetFrameMaterial()
    {
        return await context.FrameMaterials.ToListAsync();

    }

    [HttpGet("/api/colors")]
    public async Task<IEnumerable<Color>> GetColor()
    {
        return await context.Color.ToListAsync();

    }

    [HttpGet("/api/categories")]
    public async Task<IEnumerable<Category>> GetCategories()
    {
        return await context.Categories.ToListAsync();

    }
    [HttpGet("/api/styles")]
    public async Task<IEnumerable<Style>> GetStyles()
    {
        return await context.Styles.ToListAsync();

    }
    [HttpGet("/api/idealFor")]
    public async Task<IEnumerable<IdealFor>> GetIdealFor()
    {
        return await context.IdealFor.ToListAsync();

    }
    [HttpGet("/api/lensColors")]
    public async Task<IEnumerable<LensColor>> GetLensColors()
    {
        return await context.LensColors.ToListAsync();

    }

    [HttpGet("/api/lensMaterials")]
    public async Task<IEnumerable<LensMaterial>> GetLensMaterials()
    {
        return await context.LensMaterials.ToListAsync();

    }

    [HttpGet("/api/frameTypes")]
    public async Task<IEnumerable<FrameType>> GetFrameTypes()
    {
        return await context.FrameTypes.ToListAsync();

    }
    [HttpGet("/api/sizes")]
    public async Task<IEnumerable<Size>> GetSize()
    {
        return await context.Sizes.ToListAsync();

    }





}