using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace doublebattery.Models
{
    [Table("Products")]
    public class Product
    {
        public int Id { get; set; }

        [Required]
        [StringLength(11)]
        public string Sku { get; set; }

        public Model Model { get; set; }
        public int ModelId { get; set; } //Done

        [Required]
        public string ColorChildName { get; set; } //Done

        public ColorChildId ColorChildId { get; set; }

        public SizeChildId SizeChildId { get; set; }

        [Required]
        public string SizeChildName { get; set; } //Done

        [Required]
        public string BrandColorName { get; set; } //Done

        [Required]
        public Color FrameColor { get; set; } //Done

        [Required]
        public int FrameColorId { get; set; } //Done

        [Required]
        public int TempleColorId { get; set; } //Done

        [Required]
        public LensColor LensColor { get; set; } //Done

        [Required]
        public string BrandSizeName { get; set; } //Done

        [Required]
        public Size Size { get; set; }

        [Required]
        public FrameMaterial FrameMaterial { get; set; }

        [Required]
        public int FrameMaterialId { get; set; } //Done

        [Required]
        public int TempleMaterialId { get; set; } //Done

        [Required]
        public LensMaterial LensMaterial { get; set; } //Done

        [Required]
        public IdealFor IdealFor { get; set; } //Done

        [Required]
        public Category Category { get; set; } //Done

        [Required]
        public Style Style { get; set; } //Done

        [Required]
        public FrameType FrameType { get; set; }  //Done

        public DateTime LastUpdate { get; set; }

        public int LensWidth { get; set; }
        public int LensHeight { get; set; }
        public int BridgeSize { get; set; }
        public int TempleLength { get; set; }



    }
}