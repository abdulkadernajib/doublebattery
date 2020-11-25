using doublebattery.Models;
using Microsoft.EntityFrameworkCore;

namespace doublebattery.Persistence
{
    public class DoubleBatteryDbContext : DbContext
    {
        public DoubleBatteryDbContext(DbContextOptions<DoubleBatteryDbContext> Options) : base(Options)
        {
        }
        public DbSet<Brand> Brand { get; set; }
        public DbSet<Model> Models { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<Color> Color { get; set; }
        public DbSet<FrameMaterial> FrameMaterials { get; set; }
        public DbSet<LensMaterial> LensMaterials { get; set; }
        public DbSet<LensColor> LensColors { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Style> Styles { get; set; }
        public DbSet<FrameType> FrameTypes { get; set; }
        public DbSet<IdealFor> IdealFor { get; set; }
        public DbSet<Size> Sizes { get; set; }
        public DbSet<ColorChildId> ColorChildIds { get; set; }
        public DbSet<SizeChildId> SizeChildIds { get; set; }
    }
}